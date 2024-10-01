using UnityEngine;

namespace GameManager
{
    public class Restart : MonoBehaviour
    {
        public GameOverManager gom;
    
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                gom.RestartGame();
            }
        }
    }
}
