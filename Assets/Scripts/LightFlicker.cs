using System.Collections;
using System.Collections.Generic;
using QuestSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightFlicker : MonoBehaviour
{
    public GameObject l1;
    public GameObject l2;
    public int interval;
    public int interval_d;
    private int t;
    // Start is called before the first frame update
    void Start()
    {
        ChangeTime();
        t = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(t == interval)
        {
            l1.SetActive(false); 
            l2.SetActive(false);
        }
        else if(t == interval+interval_d)
        {
            t = 0;
            l1.SetActive(true);
            l2.SetActive(true);
            ChangeTime();
        }
        t++;
    }
    void ChangeTime()
    {
        interval = Random.Range(30, 50);
        interval_d = Random.Range(2, 4);
    }
}
