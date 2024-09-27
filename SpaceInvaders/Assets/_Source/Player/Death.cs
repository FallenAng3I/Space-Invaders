using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOver;
    [SerializeField] private GameObject player;
    [SerializeField] private HealthUI ui;
    
    public void Die()
    {
        ui.UpdateHealthUI();
        Debug.Log("Player has died!");
        gameObject.SetActive(false);
        gameOver.ShowGameOverMenu();
    }
}
