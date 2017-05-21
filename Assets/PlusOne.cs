using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusOne : MonoBehaviour {
    int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * 1f * Time.deltaTime, Space.World);
        count++;
        if (count > 50) {
            Destroy(this.gameObject);
        }
	}
}
