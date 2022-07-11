using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private Text timerText;
    private Camera _camera;
    private Vector3 s;
    private Transform _cameraTransform;
    private Vector3 _originalPosition;

    private float _timeLeft = 0f;
    private bool _timerOn = false;

    private void Start()
    {
        s = new Vector3();
        _camera = Camera.main;
        _cameraTransform = _camera.GetComponent<Transform>();
        _originalPosition = _cameraTransform.transform.position;
        _timeLeft = time;
        _timerOn = true;
    }

    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                if(_timeLeft == 6)
                {
                    _camera = Camera.main;
                    _cameraTransform = _camera.GetComponent<Transform>();
                    _originalPosition = _cameraTransform.transform.position;
                }
                if (_timeLeft < 6)
                {
                    _cameraTransform.position = _originalPosition + new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
                }
                _timeLeft -= Time.deltaTime;
                UpdateTimeText();
            }
            else
            {
                _timeLeft = time;
                _timerOn = false; 
                SceneManager.LoadScene("Defeat");
            }
            if(SceneManager.GetActiveScene().name == "Win")
            {
                _timerOn = false;
                _timeLeft = time;
                timerText.text = " ";
            }
            if(SceneManager.GetActiveScene().name == "Hallway" && _timerOn == false)
            {
                _timerOn = true;
            }
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
            _timeLeft = 0;

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
