using UnityEngine;

public class Movement : MonoBehaviour
{
    public Player player;
    
    public float boundaryX = 3f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * (player.speed * Time.deltaTime);
        transform.position += movement;
        
        var newPosition = transform.position.x;
        newPosition = Mathf.Clamp(newPosition, -boundaryX, boundaryX);
        transform.position = new Vector3(newPosition, transform.position.y, transform.position.z);
    }
}
