using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    private Animator anim;
    public bool leftpunch;
    public bool rightpunch;
    
    void Start () {
       
        anim = gameObject.GetComponentInParent<Animator>();
	}
	

    //controls for player
    private void FixedUpdate()
    {
       
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            anim.SetTrigger("walkingforward");
        }
       
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            anim.SetTrigger("walkingbackwards");
        }
       
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetTrigger("walkingleft");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("walkingright");
        }
        if (!Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("walkingright", false);
        }
        if (!Input.GetKeyDown(KeyCode.LeftArrow))
        {
            anim.SetBool("walkingleft", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("punchleft");
            leftpunch = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("punchright");
            rightpunch = true;
        }
    }
}
