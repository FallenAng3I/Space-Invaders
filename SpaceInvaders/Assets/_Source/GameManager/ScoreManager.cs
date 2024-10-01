using TMPro;
using UnityEngine;

namespace GameManager
{
    public class ScoreManager : MonoBehaviour
    {
        public TMP_Text scoreText;
        private int score = 0;

        private void Start()
        {
            UpdateScoreText();
        }
    
        public void AddScore(int maxHealth)
        {
            int points = 10 * maxHealth;
            score += points;
            UpdateScoreText();
        }
    
        public int GetScore()
        {
            return score;
        }
    
        private void UpdateScoreText()
        {
            scoreText.text = " " + score;
        }
    }
}