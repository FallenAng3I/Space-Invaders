using EnemySystem;
using UnityEngine;

namespace GameManager
{
    public class VictoryManager : MonoBehaviour
    {
        [SerializeField] private EnemyMove enemyMove;
        [SerializeField] private GameObject victoryPanel;

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
            }
        }
    }
}