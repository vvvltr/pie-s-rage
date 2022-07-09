using System;
using UnityEngine;

namespace InventoryScripts
{
    public class SudokuUIController : MonoBehaviour
    {
        public GameObject SudokuUI;
        private void OnMouseDown()
        {
            SudokuUI.SetActive(false);
        }
    }
}