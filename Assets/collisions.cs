using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour {
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
	}

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("fists"))
        {
            anim.SetBool("gothit", true);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
