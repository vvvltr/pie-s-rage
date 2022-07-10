using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class HistoryCanvasScript : MonoBehaviour
    {
        public QuestManager questManager;
        
        public GameObject HistoryCanvas;
        public Action Action;

        public BoxCollider RoomCollider;
        

        public void Start()
        {
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;

            Action += DestroyAfterSeconds;
        }

        public void DestroyAfterSeconds()
        {
            Destroy(HistoryCanvas, 7);
            Destroy(RoomCollider, 7);

            Action -= DestroyAfterSeconds;
        }
        
        private void Update()
        {
            Action?.Invoke();
            if (questManager.CompletedQuests.Count > 0)
            {
                Destroy(HistoryCanvas);
                Destroy(RoomCollider);
            }
        }
    }
}