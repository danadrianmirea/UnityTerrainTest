using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private CharacterController controller;
    private Rigidbody rb;

    private float speed = 10.0f;
    private float rotationSpeed = 3.0f;
    private float jumpSpeed = 100.0f;

    // Use this for initialization
    void Start () {
		//controller = GetComponent<CharacterController>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //Vector3 rightPos = new Vector3(3, 1.5f, transform.position.z);
        //Vector3 leftPos = new Vector3(-3, 1.5f, transform.position.z);
        //Vector3 middlePos = new Vector3(0, 1.5f, transform.position.z);

        //if (controller.isGrounded) 
        //{
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddForce( new Vector3(1.0f, 0.0f, 0.0f) * speed * Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
            //transform.Translate(-Vector3.right * Time.deltaTime * speed);
        }
        else if(Input.GetKey(KeyCode.D)) 
        {
            
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
            //transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        //}

        if(Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Am facut combinatia");
            rb.AddForce(new Vector3(0.0f, jumpSpeed, 0.0f) * speed * Time.deltaTime);
        }

        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.position = Vector3.MoveTowards(transform.position, leftPos, step);


    }
}
