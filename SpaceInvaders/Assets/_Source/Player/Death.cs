using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private GameOverManager gameOver;
    [SerializeField] private GameObject player;
    
    public void Die()
    {
        Debug.Log("Player has died!");
        gameObject.SetActive(false);
        gameOver.ShowGameOverMenu();
    }
}
