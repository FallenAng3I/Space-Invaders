using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOverManager;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            gameOverManager.ShowGameOverMenu();
        }
    }
}