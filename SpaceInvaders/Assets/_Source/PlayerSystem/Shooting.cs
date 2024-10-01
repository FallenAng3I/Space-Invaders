using UnityEngine;

namespace PlayerSystem
{
    public class Shooting : MonoBehaviour
    {
        [SerializeField] public GameObject bulletPrefab;
        [SerializeField] public Transform firePoint;
        private float fireRate = 0.75f;
        private float nextFireTime = 0f;

        private void Update()
        {
            if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
            {
                Shoot();
                nextFireTime = Time.time + fireRate;
            }
        }

        private void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint.up * bullet.GetComponent<Bullet>().speed;
        }
    }
}