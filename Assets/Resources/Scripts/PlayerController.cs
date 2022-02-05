using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed;
    BoxCollider box;
    void Start()
    {
        box = GetComponent<BoxCollider>();
        GameObject player_block = new GameObject("player-box");
        player_block.transform.parent = transform;
        player_block.transform.localPosition = Vector3.zero;
        player_block.transform.rotation = new Quaternion(0, 0, 0, 0);
        player_block.drawRectangle(box.bounds.size.x, box.bounds.size.z, 0.2f);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += position * speed * Time.deltaTime;
        
    }
}
