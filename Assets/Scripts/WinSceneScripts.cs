using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class WinSceneScripts : MonoBehaviour
    {
        public void ReturnToMenu()
        {
            Application.Quit();
        }
    }
}