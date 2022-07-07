using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem
{
    public class QuestDisplayed : MonoBehaviour
    {
        public QuestDisplayed Instance;
        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public GameObject Title;
        public GameObject Description;
    }
}