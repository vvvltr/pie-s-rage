using System;
using UnityEngine;

namespace InventoryScripts
{
    public class SudokuItemController : MonoBehaviour
    {
        
        public GameObject SudokuGameObject;
        public GameObject SudokuUI;

        public void Start()
        {
        }

        private void OnMouseDown()
        {
            DisplaySudokuUI();
        }

        public void DisplaySudokuUI()
        {
            SudokuUI.SetActive(true);
        }
    }
}