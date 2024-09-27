using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPaused = true;
        //Application.Quit();
    }
}
