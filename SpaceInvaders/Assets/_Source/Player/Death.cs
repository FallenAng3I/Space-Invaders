using UnityEngine;
using UnityEngine.Serialization;

public class Death : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOver;
    [SerializeField] private GameObject player;
    [FormerlySerializedAs("ui")] [SerializeField] private HealthBar bar;
    
    public void Die()
    {
        bar.UpdateHealthUI();
        Debug.Log("Player has died!");
        gameObject.SetActive(false);
        gameOver.ShowGameOverMenu();
    }
}
