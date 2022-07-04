using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public CameraMovement Instance;

    [SerializeField] public Camera rightCamera;
    [SerializeField] public Camera leftCamera;

    public void Awake()
    {
        Instance = this;
        rightCamera.enabled = true;
        leftCamera.enabled = false;
    }
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    public void SwitchToRight()
    {
        leftCamera.enabled = false;
        rightCamera.enabled = true;
        rightCamera.depth = 5;
        leftCamera.depth = 0;
    }

    public void SwitchToLeft()
    {
        rightCamera.enabled = true;
        leftCamera.enabled = false;
        leftCamera.depth = 5;
        rightCamera.depth = 0;
    }
    
}
