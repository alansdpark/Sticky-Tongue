using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateFlies : MonoBehaviour {
    public GameObject fly;
    public GameObject bee;
    public int gameOver;
    // 1-3 is fly, 4 is bee
    float which = 1f;
    private float timeToWait;
    private KeepAndSetScore keepAndSetScore;

	// Use this for initialization
	void Start () {
        gameOver = 0;
        keepAndSetScore = GetComponent<KeepAndSetScore>();
        timeToWait = Random.Range(2f, 3f);
        StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
        if (keepAndSetScore.gameScore > 5) {
            timeToWait = Random.Range(1f, 1.5f);
        }
        if (keepAndSetScore.gameScore > 10) {
            timeToWait = Random.Range(0.7f, 1.2f);
        }
        if(keepAndSetScore.gameScore > 25) {
            timeToWait = Random.Range(0.45f, 1.1f);
        }
	}

    IEnumerator spawn() {
        while (gameOver != 1) {
            which = Random.Range(1f, 4f);
            if (which < 3.5f) {
                Instantiate(fly);
            }
            else {
                Instantiate(bee);
            }
            yield return new WaitForSeconds(timeToWait);   
        }
    }
}
