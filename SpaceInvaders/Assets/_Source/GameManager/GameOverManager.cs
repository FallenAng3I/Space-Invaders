using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private ScoreManager scoreManager;
     
    public void ShowGameOverMenu()
    {
        Time.timeScale = 0;
        deathPanel.SetActive(true);
        scoreText.text = "Your Score: " + scoreManager.GetScore();
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}