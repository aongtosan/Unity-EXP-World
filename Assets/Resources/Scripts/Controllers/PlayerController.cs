using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Stats
{
    // Start is called before the first frame update
    Animator player_animator;
    Quaternion targetRotation;
    void Awake()
    {
        GameObject playerCha = transform.GetChild(0).gameObject;
        player_animator = playerCha.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
  
        if (horizontal > 0f || horizontal <0 || vertical > 0f || vertical <0f)
        {
            Vector3 position = new Vector3(horizontal, 0, vertical);
            targetRotation = Quaternion.LookRotation(position - transform.position);
            transform.position += (position * MoveSpeed * Time.deltaTime);
           
            targetRotation = Quaternion.RotateTowards(transform.rotation,targetRotation,360 * Time.deltaTime);
            transform.rotation = targetRotation;
            player_animator.SetBool("walk", true);
           
        }
        else if(Mathf.Approximately(horizontal,0)&& Mathf.Approximately(vertical,0))
        {
         //  Vector3 position = new Vector3(horizontal, 0, vertical);
            targetRotation = Quaternion.RotateTowards(transform.rotation,targetRotation,360 * Time.deltaTime);
            transform.rotation = targetRotation;
            player_animator.SetBool("walk", false);
        }
        
    }
}
