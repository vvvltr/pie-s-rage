using System;
using UnityEngine;

namespace QuestSystem
{
    public class CodePanelUIController : MonoBehaviour
    {
        public QuestManager questManager;
        
        public GameObject panelUI;
        public GameObject Room;

        private void Start()
        {
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
        }

        public void OnMouseDown()
        {
            if (questManager.Quests[2].isCompleted && questManager.CompletedQuests.Count > 2)
            {
                panelUI.SetActive(true);
                Room.SetActive(false);
            }
        }

    }
}