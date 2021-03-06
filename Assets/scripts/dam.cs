﻿using System.Collections;
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
    ParticleSystem part;
    private int cockiness;
    public Material mat;
    private ColorBlock col;
    private bool stillalive;
    AudioSource aud;
    //giving values to variables
    private void Start()
    {
        stillalive = true;
        aud = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
        vic = enemy.GetComponent<dam>();
        part = enemy.GetComponentInChildren<ParticleSystem>();

    }
    //if damage occurs 
    public void damage()
    {

        health -= 10;
        part.Play();
        anim.SetBool("gothit", false);
        cockiness = Random.Range(1, 3);
        aud.Play();
    }

    //health check list
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
