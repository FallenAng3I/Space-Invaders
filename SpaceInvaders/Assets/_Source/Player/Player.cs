using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        public int health = 3;
        public float speed;
    
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                int damage = 1;
                TakeDamage(damage);
            }
        }
        
        public void TakeDamage(int damage)
        {
            health -= damage;
            
            if (health <= 0)
            {
                Die();
            }
        }
        
        private void Die()
        {
            Debug.Log("Player has died!");
            gameObject.SetActive(false);
        }
    }
}