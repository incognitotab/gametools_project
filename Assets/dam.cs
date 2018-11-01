using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dam : MonoBehaviour {
    Animator anim;
    public static int health=100;
    public Slider healthbar;
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void damage()
    {
        health -= 5;
        anim.SetBool("gothit", false);
    }
	
	// Update is called once per frame
	void Update () {
        healthbar.value = health;
	}
}
