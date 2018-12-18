using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {
    Animator anim;
    [SerializeField] private int randomiser;
    [SerializeField] private float timer;
	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponentInParent<Animator>();
	}
	
	//randomiser ai
	void Update () {
        timer +=  Time.deltaTime;
        randomiser = Random.Range(1, 7);
            switch (randomiser)
        {
            case 1:
                anim.SetTrigger("punchleft");
                break;
            case 2:
                anim.SetTrigger("punchright");
                break;
            case 3:
                anim.SetBool("walkingright", true);
                break;
             case 4:
                anim.SetBool("walkingleft", true);
                break;
            case 5:
                anim.SetTrigger("walkingforward");
                break;
            case 6:
                anim.SetTrigger("walkingbackwards");
                break;
        
          
        }
        if (timer >= 0.05)
        {
            anim.SetBool("walkingright", false);
            anim.SetBool("walkingleft", false);
            anim.SetBool("walkingforward", false);
            anim.SetBool("walkingbackwards", false);
            timer = 0;
        }
	}
}
