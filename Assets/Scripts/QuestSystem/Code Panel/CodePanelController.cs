using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem
{
    public class CodePanelController : MonoBehaviour
    {
        public QuestManager questManager;

        public CodePanelController Instance;
        public string numbersEntered;

        public GameObject numbersDisplay;
        
        public void Awake()
        {
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

        private void Start()
        {
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
            
        }

        private void Update()
        {
            Text text = numbersDisplay.GetComponent("Text") as Text;
            text.text = numbersEntered;
        }
    }
}