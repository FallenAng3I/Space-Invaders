using UnityEngine;

namespace Enemy
{
    public class EnemyShooting : MonoBehaviour
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firePoint;
        [SerializeField] private float fireRate; // Скорость стрельбы
        private float nextFireTime = 0f;
        private Enemy enemy; // Ссылка на Enemy компонент

        private void Start()
        {
            enemy = GetComponent<Enemy>(); // Получаем Enemy компонент
            // Случайная задержка перед первым выстрелом
            nextFireTime = Time.time + Random.Range(0f, fireRate);
        }

        private void Update()
        {
            if (Time.time >= nextFireTime && enemy.canShoot)
            {
                // Проверяем, есть ли враги ниже текущего, перед стрельбой
                if (CanShoot())
                {
                    ShootDown();
                    // Установка следующего времени стрельбы с случайной задержкой
                    nextFireTime = Time.time + Random.Range(0.5f, fireRate);
                }
            }
        }

        private void ShootDown()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            if (bullet.TryGetComponent(out Rigidbody2D rbBullet))
            {
                rbBullet.velocity = Vector2.down * bullet.GetComponent<Bullet>().speed;
            }
        }

        private bool CanShoot()
        {
            // Проверьте, есть ли другие враги, находящиеся ниже текущего
            Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 1.0f);
            foreach (var collider in colliders)
            {
                if (collider.CompareTag("Enemy") && collider.transform.position.y < transform.position.y)
                {
                    return false; // Если есть враг ниже, то не стрелять
                }
            }
            return true;
        }
    }
}