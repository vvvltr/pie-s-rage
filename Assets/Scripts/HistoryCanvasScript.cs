using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class HistoryCanvasScript : MonoBehaviour
    {
        public GameObject HistoryCanvas;
        public Action Action;

        public BoxCollider RoomCollider;

        public void Start()
        {
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
        }
    }
}