using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed;
    Animator player_animator;
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
            transform.position += position * speed * Time.deltaTime;
            player_animator.SetBool("walk", true);
        }
        else
        {
            player_animator.SetBool("walk", false);
        }
        
    }
}
