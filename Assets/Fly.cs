using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour {
    // Change speed based on score up to a certain speed
    public float speed;

	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
	}
}
