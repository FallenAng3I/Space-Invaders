using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != LayerMask.NameToLayer("Finish"))
        {
            Destroy(gameObject);
        }
    }
}