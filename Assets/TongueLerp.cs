using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueLerp : MonoBehaviour {
    public GameObject StartPosition;
    public GameObject endPosition;
    public AudioSource tongueSound;
    float startTime;
    float totalDistanceToDest;
    float speed = 30f;
    bool inAction = false;
    bool inActionDown = false;
    bool currentlyDoing = false;
	// Use this for initialization
	void Start () {
        totalDistanceToDest = Vector3.Distance(StartPosition.transform.position, endPosition.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        if (currentlyDoing != true) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                tongueSound.Play();
                currentlyDoing = true;
                startTime = Time.time;
                inAction = true;
            }
        }
        if (inAction) {
            float currentDuration = (Time.time - startTime) * speed;
            // Fraction is 0 - 1
            float journeyFraction = currentDuration / totalDistanceToDest;
            transform.position = Vector3.Lerp(StartPosition.transform.position, endPosition.transform.position, journeyFraction);
            if (transform.position == endPosition.transform.position) {
                inAction = false;
                inActionDown = true;
            }
        }
        if (inActionDown) {
            StartCoroutine(goBack());
            float currentDuration = (Time.time - startTime) * speed;
            float journeyFraction = currentDuration / totalDistanceToDest;
            transform.position = Vector3.Lerp(endPosition.transform.position, StartPosition.transform.position, journeyFraction);
            if (transform.position == StartPosition.transform.position) {
                inActionDown = false;
                currentlyDoing = false;
            }
        }
	}

    IEnumerator goBack() {
        yield return new WaitForSeconds(0.1f);
    }
}
