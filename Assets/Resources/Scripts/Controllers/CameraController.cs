using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Transform playerPosition;
    Vector3 cameraOffset;
    void Start()
    {
        cameraOffset = transform.position - playerPosition.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z+cameraOffset.z);
        transform.LookAt(playerPosition);
 
    }
}
