using System;
using UnityEngine;

namespace QuestSystem
{
    public class UIController : MonoBehaviour
    {
        public GameObject panelUI;

        public void OnMouseDown()
        {
            panelUI.SetActive(true);
        }

    }
}