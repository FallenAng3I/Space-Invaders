using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOverManager;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            Debug.Log("Game Over: Enemy reached the bottom!");
            gameOverManager.ShowGameOverMenu();
        }
    }
}