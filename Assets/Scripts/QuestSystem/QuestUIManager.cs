using UnityEngine;

namespace QuestSystem
{
    public class QuestUIManager : MonoBehaviour
    {
        private static QuestUIManager Instance = null; // static (class level) variable
        
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