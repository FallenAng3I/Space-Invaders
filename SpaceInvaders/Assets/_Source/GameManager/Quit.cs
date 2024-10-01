using UnityEngine;

namespace GameManager
{
    public class Quit : MonoBehaviour
    {
        public void QuitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPaused = true;
#else
        Application.Quit();
#endif
        }
    }
}
