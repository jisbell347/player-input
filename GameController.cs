﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            Debug.Log("Jump!");
        }

	    if (Input.GetKey("left")) {
	        Debug.Log("Move Left!");
	    }

	    if (Input.GetKey("right")) {
	        Debug.Log("Move Right!");
	    }
	}
}
