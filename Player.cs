﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 3.5f;
    public float jumpingForce = 300f;

    private bool canJump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey("right")) {
	        transform.position += Vector3.right * speed * Time.deltaTime;
	    }

	    if (Input.GetKey("left")) {
	        transform.position += Vector3.left * speed * Time.deltaTime;
	    }
        if (Input.GetKeyDown("space") && canJump) {
            canJump = false;
            GetComponent<Rigidbody>().AddForce(0, jumpingForce, 0);

        }
	}

    void OnCollisionEnter (Collision collision)
    {
        if(collision.transform.name == "Floor") {
            canJump = true;
        }
    }
}
