using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Player.Player player;
    [SerializeField] private int numOfHealth;
    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite hp;

    private void FixedUpdate()
    {
        if (player.health > numOfHealth)
        {
            player.health = numOfHealth;
        }

        UpdateHealthUI();
    }
    
    public void UpdateHealthUI()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(player.health))
            {
                hearts[i].gameObject.SetActive(true);
                hearts[i].sprite = hp;
            }
            else
            {
                hearts[i].gameObject.SetActive(false);
            }
        }
    }
}
