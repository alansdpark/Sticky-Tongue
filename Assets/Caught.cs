﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caught : MonoBehaviour {
    float speed = 30f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
	}
}
