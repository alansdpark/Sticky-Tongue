using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FlyTrigger : MonoBehaviour {
    
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject miss;
    public int countMissed = 0;

    public GameObject gameOverUI;

    public GameObject instantFlies;

    private InstantiateFlies instantiateFlies;

    private void OnTriggerEnter(Collider other) {
        if (other.tag.Equals("Fly")) {
            Debug.Log("-1 Lives!");
            countMissed++;
            Destroy(other.gameObject);
            checkCountMissed();   
            return;
        }
        if (other.tag.Equals("Bee")) {
            Debug.Log("Avoided bee!");
            Destroy(other.gameObject);
            return;
        }
    }

	// Use this for initialization
	void Start () {
        instantiateFlies = instantFlies.GetComponent<InstantiateFlies>();
        gameOverUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void checkCountMissed() {
        if (countMissed == 1) {
            Instantiate(miss);
            Instantiate(one);
        }
        if (countMissed == 2) {
            Instantiate(miss);
            Instantiate(two);
        }
        if (countMissed == 3) {
            Instantiate(miss);
            Instantiate(three);
            EndGame();
            Debug.Log("You Lose!");
        }
        return;
    }

    public void EndGame() {
        gameOverUI.SetActive(true);
        instantiateFlies.gameOver = 1;
    }
}
