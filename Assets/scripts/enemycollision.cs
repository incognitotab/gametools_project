using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycollision : MonoBehaviour {
    Animator anim;
    //ai special collision script so player wont easily win
    private void Start()
    {
        anim=gameObject.GetComponentInParent<Animator>();
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("fists2"))
        {
            anim.SetBool("gothit", true);
        }
    }

    
}
