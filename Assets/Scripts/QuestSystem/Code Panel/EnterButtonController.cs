using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem
{
    public class EnterButtonController : MonoBehaviour
    {
        public CodePanelController codePanelController;

        public GameObject ErrorMessage;
        public CodePanelQuest codePanelQuest;

        public CodePanelUIController codePanelUIController;

        public Action action;

        private void Start()
        {
            //codePanelController = GameObject.Find("CodePanelLock").GetComponent("CodePanelController") as CodePanelController;
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
            if (codePanelController.numbersEntered.Equals(code))
            {
                codePanelQuest.EndQuest();
                codePanelUIController.panelUI.SetActive(false);
                codePanelUIController.Room.SetActive(true);

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