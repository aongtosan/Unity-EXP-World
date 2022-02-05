using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Transform playerPosition;
    BoxCollider box;
    void Awake()
    {
        box = GetComponent<BoxCollider>();
        GameObject area = new GameObject("chest-area");
        area.transform.parent = transform;
        area.transform.localPosition = Vector3.zero;
        area.transform.rotation = new Quaternion(0, 0, 0, 0);
        area.DrawCircle(box.bounds.size.x,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject area = GameObject.Find("chest-area");
       if((playerPosition.position-transform.position).magnitude< box.bounds.size.x )
        {
            area.GetComponent<LineRenderer>().enabled = true;
        }
        else
        {
            area.GetComponent<LineRenderer>().enabled = false;
        }
           
    }
}
