using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueTrigger : MonoBehaviour {

    public GameObject caughtFly;
    public GameObject plusOneObject;
    public GameObject missedPoint;
    public GameObject caughtBee;

    public GameObject noX;
    public GameObject oneX;
    public GameObject twoX;
    public GameObject threeX;

    public GameObject flyTriggerMissed;
    private FlyTrigger flyTrigger;

    public GameObject gameManager;
    private KeepAndSetScore keepAndSetScore;

    public int missedAccordingToTrigger;

	// Use this for initialization
	void Start () {
		
	}

    void Awake() {
        flyTrigger = flyTriggerMissed.GetComponent<FlyTrigger>();
        keepAndSetScore = gameManager.GetComponent<KeepAndSetScore>();
    }
	
	// Update is called once per frame
	void Update () {
        missedAccordingToTrigger = flyTrigger.countMissed;
	}

    void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("Fly")) {
            Debug.Log("+1 Point");
            keepAndSetScore.gameScore += 1;
            keepAndSetScore.setScoreText();
            Destroy(other.gameObject);
            Instantiate(caughtFly);
            Instantiate(plusOneObject);
            return;
        }
        if (other.tag.Equals("Bee")) {
            Debug.Log("-1 Point");
            Destroy(other.gameObject);
            Instantiate(caughtBee);
            Instantiate(missedPoint);
            missedAccordingToTrigger++;
            checkHowManyMissedAndAdd();
            return;
        }
    }

    void checkHowManyMissedAndAdd() {
        if (missedAccordingToTrigger == 1) {
            flyTrigger.countMissed += 1;
            Instantiate(oneX);
        }
        if (missedAccordingToTrigger == 2) {
            flyTrigger.countMissed += 1;
            Instantiate(twoX);
        }
        if (missedAccordingToTrigger == 3) {
            flyTrigger.countMissed += 1;
            Instantiate(threeX);
            flyTrigger.EndGame();
            Debug.Log("You Lose!");
        }
        return;
    }
}
