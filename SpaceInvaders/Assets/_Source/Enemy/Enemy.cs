using System.Collections;
using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int maxHealth;
        private int currentHealth;
        public bool canShoot = true;
        
        private ScoreManager scoreManager;

        private void Start()
        {
            currentHealth = maxHealth;
            StartCoroutine(DelayShooting());
            scoreManager = FindObjectOfType<ScoreManager>();
        }
        
        private IEnumerator DelayShooting()
        {
            yield return new WaitForSeconds(2);
            canShoot = true;
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Bullet")) //TODO сменить на layer
            {
                TakeDamage(1);
            }
        }

        void TakeDamage(int damage)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                scoreManager.AddScore(maxHealth);
                Destroy(gameObject);
            }
        }

        public void DisableShooting()
        {
            canShoot = false;
        }
    }
}