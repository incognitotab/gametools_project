using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoplayercollision : MonoBehaviour
{
    Animator anim;
    player1movement move;
    public GameObject enemy;
    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponentInParent<Animator>();
        move = enemy.GetComponent<player1movement>();
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("fists") && move.leftpunch == true || collision.gameObject.CompareTag("fists") && move.rightpunch == true)
        {
            anim.SetBool("gothit", true);
            move.leftpunch = false;
            move.rightpunch = false;
        }
    }


}
