using System;
using UnityEngine;

namespace QuestSystem
{
    public class СloseButtonController : MonoBehaviour
    {
        public CodePanelUIController codePanelUIController;

        private void Start()
        {
            
            codePanelUIController = GameObject.Find("CodeLock").GetComponent("CodePanelUIController") as CodePanelUIController;
        }

        public void ClosePanel()
        {
            codePanelUIController.panelUI.SetActive(false);
            codePanelUIController.Room.SetActive(true);
            
        }
    }
}