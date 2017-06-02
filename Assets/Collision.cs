using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    // Use this for initialization
    public GameObject alien;
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
            rb.AddForce(50f, 10f, 0, ForceMode.Impulse);
            Debug.Log("Cow Fucked");
        }
    }
}
