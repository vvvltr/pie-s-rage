using System;
using UnityEngine;

namespace InventoryScripts
{
    public class SudokuItemController : MonoBehaviour
    {
        public QuestManager questManager;
        public GameObject SudokuGameObject;
        public GameObject SudokuUI;

        public void Start()
        {
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
        }

        private void OnMouseDown()
        {
            DisplaySudokuUI();
        }

        public void DisplaySudokuUI()
        {
            SudokuUI.SetActive(true);
        }

        private void Update()
        {
           
        }
    }
}