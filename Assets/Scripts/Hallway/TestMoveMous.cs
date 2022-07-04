using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoveMous : MonoBehaviour
{
    private int col;
    private Vector3 pos;
    public GameObject cheker;
    void Start()
    {
        pos = transform.position;
        col = 0;
    }
    void Update()
    {
        if(col != 0)
        {
            transform.position = pos;
            col--;
        }
        else
        {
            pos = transform.position;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            //transform.position = pos;
            cheker.GetComponent<Moves>().inCollision();
            col = 2;
        }
        else
        {
            //pos = transform.position;
        }
    }
    bool IsCollising()
    {
        return !(col == 0);
    }
}
