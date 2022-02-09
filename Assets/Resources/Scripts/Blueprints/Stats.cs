using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    float stamina;
    public float Stamina
    {
        get { return stamina; }
        set { stamina = value; }
    }
    [SerializeField]
    float moveSpeed;
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { moveSpeed = value; }
    }
    [SerializeField]
    float turnSpeed;
    public float TurnSpeed
    {
        get { return turnSpeed; }
        set { turnSpeed = value; }
    }
    [SerializeField]
    float health;
    public float Health
    {
        get { return health; }
        set { health = value; }
    }
    [SerializeField]
    float attack;
    public float Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    [SerializeField]
    float actionSpeed;
    public float ActionSpeed
    {
        get { return actionSpeed; }
        set { actionSpeed = value; }
    }

}
