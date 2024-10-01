using UnityEngine;

namespace PlayerSystem
{
    public class Movement : MonoBehaviour
    {
        public Player player;

        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
        
            Vector3 movement = new Vector3(horizontalInput, 0, 0) * (player.speed * Time.deltaTime);
            transform.position += movement;
        }
    }
}
