using UnityEngine;

namespace Enemy
{
    public class EnemyShooting : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firePoint;
        [SerializeField] private float fireRate; // Скорость стрельбы
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

            if (bullet.TryGetComponent(out Rigidbody2D rbBullet))
            {
                rbBullet.velocity = Vector2.down * bullet.GetComponent<Bullet>().speed;
            }
            //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        }
    }
}