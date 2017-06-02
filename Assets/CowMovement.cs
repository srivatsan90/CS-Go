using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowMovement : MonoBehaviour {
    public float speed;
    public Animator cowAnim;
	// Use this for initialization
	void Start () {
        cowAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            cowAnim.SetFloat("Speed",1f);
        }
        else
        {
            cowAnim.SetFloat("Speed", 0f);
        }


        if (Input.GetKey(KeyCode.Space))
            cowAnim.SetTrigger("Attack");

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -1, 0);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, 1, 0);

    }
}
