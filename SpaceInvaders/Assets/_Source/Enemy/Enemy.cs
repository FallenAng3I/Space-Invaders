using UnityEngine;

namespace Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int maxHealth;
        private int currentHealth;
        private ScoreManager scoreManager;

        private void Start()
        {
            currentHealth = maxHealth;
            scoreManager = FindObjectOfType<ScoreManager>();
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
    }
}