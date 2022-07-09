using System;
using UnityEngine;
using UnityEngine.UI;

namespace QuestSystem
{
    public class NumberButtonController : MonoBehaviour
    {
        public CodePanelController codePanelController;
        
        public GameObject ButtonText;

        private void Start()
        {
            //codePanelController = GameObject.Find("CodePanelLock").GetComponent("CodePanelController") as CodePanelController;
        }

        private void OnMouseDown()
        {
            EnterNumber();
        }

        public void EnterNumber()
        {
            Text textEntered = ButtonText.GetComponent("Text") as Text;
            if (codePanelController.numbersEntered.Length < 4)
            {
                codePanelController.numbersEntered += textEntered.text;
            }
            
        }
    }
}