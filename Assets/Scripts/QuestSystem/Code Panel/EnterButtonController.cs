using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem
{
    public class EnterButtonController : MonoBehaviour
    {
        public CodePanelController codePanelController;

        public QuestManager questManager;

        public GameObject ErrorMessage;
        public CodePanelQuest codePanelQuest;
        public GameObject InventoryUI;
        public GameObject QuestUI;
        public CodePanelUIController codePanelUIController;

        public Action action;

        private void Start()
        {
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;

        }

        public void ClearMessage()
        {
            ErrorMessage.SetActive(false);
        }

        private void OnMouseDown()
        {
            CheckCode();
        }

        public void CheckCode()
        {
            var code = "2776";
            if (codePanelController.numbersEntered.Equals(code) && questManager.Quests[2].isCompleted)
            {
                codePanelQuest.EndQuest();
                codePanelUIController.panelUI.SetActive(false);
                codePanelUIController.Room.SetActive(true);
                InventoryUI.SetActive(true);
                QuestUI.SetActive(true);
            }
            else
            {
                ErrorMessage.SetActive(true);
                Invoke("ClearMessage", 3);
            }
            codePanelController.numbersEntered = "";
        }
        

        private void Update()
        {
            
        }
    }
}