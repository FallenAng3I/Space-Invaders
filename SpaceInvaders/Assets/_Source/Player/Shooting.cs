using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Bullet bullet;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bulet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        
        Rigidbody2D rb = bulet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * bullet.speed;
    }
}