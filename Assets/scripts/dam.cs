using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dam : MonoBehaviour
{
    Animator anim;
    public int health = 100;
    public Slider healthbar;
    private float time;
    public GameObject enemy;
    dam vic;
    private int cockiness;
    public Material mat;
    private ColorBlock col;
    private bool stillalive;
    AudioSource aud;
    private void Start()
    {
        stillalive = true;
        aud = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
        vic = enemy.GetComponent<dam>();

    }

    public void damage()
    {

        health -= 10;
        
        anim.SetBool("gothit", false);
        cockiness = Random.Range(1, 3);

        aud.Play();
    }

    // Update is called once per frame
    void Update()
    {

        if (health == 50)
        {
            anim.SetInteger("damage", 50);
            time += 1;
            if (time >= 60)
            {
                anim.SetInteger("damage", 10);
            }
        }
        if (health <= 0)
        {
            stillalive = false;
            anim.SetInteger("damage", 100);
        }
        else
        {
            anim.SetInteger("damage", 10);
        }

        if (vic.health <= 0 && stillalive == true)
        {
            if (cockiness == 1)
            {
                anim.SetBool("victory1", true);

            }
            if (cockiness == 2)
            {
                anim.SetBool("victory2", true);
            }
        }
        healthbar.value = health;
    }
}
