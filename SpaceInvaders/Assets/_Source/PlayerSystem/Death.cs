using GameManager;
using UnityEngine;
using UnityEngine.Serialization;

namespace PlayerSystem
{
    public class Death : MonoBehaviour
    {
        [SerializeField] private GameOverManager gameOver;
        [SerializeField] private GameObject player;
        [FormerlySerializedAs("ui")] [SerializeField] private HealthBar bar;
    
        public void Die()
        {
            bar.UpdateHealthUI();
            gameObject.SetActive(false);
            gameOver.ShowGameOverMenu();
        }
    }
}
