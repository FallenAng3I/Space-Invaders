using UnityEngine;

namespace GameManager
{
    public class GameOverTrigger : MonoBehaviour
    {
        [SerializeField] private GameOverManager gameOverManager;

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
            {
                gameOverManager.ShowGameOverMenu();
            }
        }
    }
}