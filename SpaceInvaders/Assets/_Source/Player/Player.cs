using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public int health = 3;
        public float speed;
        public Death death;
        
        void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Bullet"))
            {
                Debug.Log("Player has damaged!");
                TakeDamage(1);
            }
        }
        
        private void TakeDamage(int damage)
        {
            health -= damage;
            
            if (health <= 0)
            {
                death.Die();
            }
        }
    }
}