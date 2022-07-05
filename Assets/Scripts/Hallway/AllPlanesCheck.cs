using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlanesCheck : MonoBehaviour
{
    private Vector3 v;
    public bool isCorrect(Vector3 r /*int x, int y, int z*/)
    {
        v = new Vector3(90, 270, 90);
        if (r==v)
        {
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool b = true;
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            b = child.GetComponent<DragDrop>().isCorrect();
            //b = isCorrect(child.localEulerAngles);
            if (!b)
            {
                Debug.Log("I am dead");
                break;
            }
        }
        if (b)
        {
            Debug.Log("I am alive!");
        }
    }
}
