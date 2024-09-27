using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }
}