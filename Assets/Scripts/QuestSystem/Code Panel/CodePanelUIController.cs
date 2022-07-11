using System;
using UnityEngine;

namespace QuestSystem
{
    public class CodePanelUIController : MonoBehaviour
    {
        public QuestManager questManager;
        
        public GameObject panelUI;
        public GameObject Room;
        public GameObject InventoryUI;
        public GameObject QuestUI;

        private void Start()
        {
            InventoryUI = GameObject.Find("InventoryUI");
            QuestUI = GameObject.Find("QuestUI");

            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
        }

        public void OnMouseDown()
        {
            if (questManager.Quests[2].isCompleted)
            {
                panelUI.SetActive(true);
                Room.SetActive(false); 
            }
            
        }

    }
}