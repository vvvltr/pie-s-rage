using UnityEngine;

namespace InventoryScripts
{
    public class UIManager : MonoBehaviour
    {
        private static UIManager Instance = null; // static (class level) variable
        
        private void Awake()
        {
            // if instance is not yet set, set it and make it persistent between scenes
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                // if instance is already set and this is not the same object, destroy it
                if (this != Instance) { Destroy(gameObject); }
            }
        }

    }
}