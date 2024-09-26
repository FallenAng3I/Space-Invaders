using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate = 1f; // Скорость стрельбы
    private float nextFireTime = 0f;

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            ShootDown();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    private void ShootDown()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * bullet.GetComponent<Bullet>().speed;
    }
}