using EnemySystem;
using UnityEngine;
using TMPro;

namespace GameManager
{
    public class VictoryManager : MonoBehaviour
    {
        [SerializeField] private GameObject victoryPanel;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private EnemyMove enemyMove;
        [SerializeField] private ScoreManager scoreManager;

        private void Update()
        {
            CheckVictory();
        }

        private void CheckVictory()
        {
            if (enemyMove.enemies.Count == 0)
            {
                ShowVictoryScreen();
            }
        }

        private void ShowVictoryScreen()
        {
            if (victoryPanel != null)
            {
                victoryPanel.SetActive(true);
                Time.timeScale = 0;
                scoreText.text = $"{scoreManager.GetScore()}";
            }
        }
    }
}