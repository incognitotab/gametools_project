using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoplayerscripttwo : MonoBehaviour {

	  private Animator anim;
    public bool leftpunch;
    public bool rightpunch;
    
    void Start () {
       
        anim = gameObject.GetComponentInParent<Animator>();
	}
	


    private void FixedUpdate()
    {
       
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("walkingforward");
        }
       
        if (Input.GetKeyDown(KeyCode.L))
        {
            anim.SetTrigger("walkingbackwards");
        }
       
        if (Input.GetKeyDown(KeyCode.I))
        {
            anim.SetTrigger("walkingleft");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            anim.SetTrigger("walkingright");
        }
        if (!Input.GetKeyDown(KeyCode.K))
        {
            anim.SetBool("walkingright", false);
        }
        if (!Input.GetKeyDown(KeyCode.I))
        {
            anim.SetBool("walkingleft", false);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            anim.SetTrigger("punchleft");
            leftpunch = true;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            anim.SetTrigger("punchright");
            rightpunch = true;
        }
    }
}

