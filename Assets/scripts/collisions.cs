using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour {
    Animator anim;
    movement move;
    public GameObject enemy;
	// naming all the variables
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
        move = enemy.GetComponent<movement>();
	}
    //if i am puching it will cause damage
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
