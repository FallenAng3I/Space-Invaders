using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject deathPanel;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private ScoreManager scoreManager;

    // Метод для вызова меню смерти
    public void ShowGameOverMenu()
    {
        Time.timeScale = 0;
        deathPanel.SetActive(true);
        scoreText.text = "Your Score: " + scoreManager.GetScore();
    }

    // Метод для перезапуска игры
    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}