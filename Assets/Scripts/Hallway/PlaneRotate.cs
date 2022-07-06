using UnityEngine;
using System.Collections;


public class PlaneRotate : MonoBehaviour
{

    private Vector3 v;
    private Vector3 v0;
    private Vector3 v1;
    public bool isCorrect()
    {
        v = new Vector3(45, 45, 45);
        v0 = new Vector3(44, 90, -2);
        Vector3 cabin = new Vector3(56.1668777f, 90, -3.0668466e-06f);
        v1 = transform.eulerAngles;
        if ((((int)v1[0] == 44 && ((int)v1[1] == 90 && (int)v1[2] == 0)) ||
            ((int)v1[0] == 68 && ((int)v1[1] == 270 && (int)v1[2] == 0))) ||
            (((int)v1[0] == 63 && ((int)v1[1] == 90 && (int)v1[2] == 0)) ||
            ((int)v1[0] == 56 && ((int)v1[1] == 90 && (int)v1[2] == 0)))
            )
        {
            return true;
        }
        Debug.Log(v[0]+","+ v[1] + "," + v[2] + ";" + (int)v1[0] + "," + (int)v1[1] + "," + (int)v1[2]);
        return false;
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began)))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //GameObject target = hit.collider.GameObject;
                string n = hit.transform.name;
                string n3 = n[0] + "" + n[1] + "" + n[2];
                if (hit.collider != null && n == transform.gameObject.name)
                {
                    transform.Rotate(0, 90, 0);
                }
            }
        }

    }
}