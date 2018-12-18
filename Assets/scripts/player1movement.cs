using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1movement : MonoBehaviour
{
    private Animator anim;
    public bool leftpunch;
    public bool rightpunch;

    void Start()
    {

        anim = gameObject.GetComponentInParent<Animator>();
    }



    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("walkingforward");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("walkingbackwards");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("walkingleft");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("walkingright");
        }
        if (!Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("walkingright", false);
        }
        if (!Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("walkingleft", false);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("punchleft");
            leftpunch = true;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("punchright");
            rightpunch = true;
        }
    }
}

