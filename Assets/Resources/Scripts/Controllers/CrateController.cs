using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Transform playerPosition;
    BoxCollider box;
    GameObject crate;
    Animator crate_animate;
    void Awake()
    {
        box = GetComponent<BoxCollider>();
        GameObject area = new GameObject("chest-area");
        crate = transform.GetChild(0).gameObject;
        crate_animate = crate.GetComponent<Animator>();
        area.transform.parent = transform;
        area.transform.localPosition = Vector3.zero;
        area.transform.rotation = new Quaternion(0, 0, 0, 0);
        area.drawRectangle(box.bounds.size.x,box.bounds.size.z, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject area = GameObject.Find("chest-area");
       if((playerPosition.position-transform.position).magnitude< box.bounds.size.x )
        {
            area.GetComponent<LineRenderer>().enabled = true;
            crate_animate.SetBool("Open", true);
        }
        else
        {
            crate_animate.SetBool("Open", false);
            area.GetComponent<LineRenderer>().enabled = false;
        }
           
    }
}
