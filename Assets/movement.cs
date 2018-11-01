using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    private Animator anim;
    
    void Start () {
       
        anim = gameObject.GetComponent<Animator>();
	}
	


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
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("punchright");
        }
    }
}
