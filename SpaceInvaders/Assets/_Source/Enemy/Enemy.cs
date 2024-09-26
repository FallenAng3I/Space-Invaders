using UnityEngine;

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
        if (collision.CompareTag("Bullet"))
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