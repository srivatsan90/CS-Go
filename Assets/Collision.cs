﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    // Use this for initialization
    public GameObject alien;
    public GameObject Explosion;
    Rigidbody rb;
	void Start () {
        rb = alien.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.gameObject.tag=="Cow")
        {
            Explosion.SetActive(true);
            
            rb.AddForce(0, 10f,-5f , ForceMode.Impulse);
            
        }
    }
}
