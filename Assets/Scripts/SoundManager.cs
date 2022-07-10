using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class SoundManager : MonoBehaviour
    {
        public static SoundManager Instance;
        public AudioSource AudioSource;
        
        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            if (SceneManager.GetActiveScene().Equals(SceneManager.GetSceneByName("Win")))
            {
                AudioSource.Stop();
            }
        }
    }
}