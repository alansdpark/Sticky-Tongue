using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KeepAndSetScore : MonoBehaviour {

    public int gameScore;

    public GameObject fly;
    public GameObject bee;
    private Fly flyScript;
    private Fly beeScript;

    public Text guiText;

    public Text currentScore;
    public Text highScore;

    private int highGameScore;

	// Use this for initialization
    void Awake() {
        flyScript = fly.GetComponent<Fly>();
        beeScript = bee.GetComponent<Fly>();
    }

	void Start () {
        beeScript.speed = 5f;
        flyScript.speed = 5f;
        gameScore = 0;
        setScoreText();
        highScore.text = (PlayerPrefs.GetInt("highscore")).ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameScore > 5) {
            flyScript.speed = 7f;
            beeScript.speed = 7f;
        }
        if (gameScore > 10) {
            flyScript.speed = 10f;
            beeScript.speed = 10f;
        }
        if (gameScore > 25) {
            flyScript.speed = 13f;
            beeScript.speed = 13f;
        }
	}

    public void setScoreText() {
        guiText.text = "Score: " + gameScore.ToString();
        currentScore.text = gameScore.ToString();
        if (gameScore > highGameScore) {
            highGameScore = gameScore;
            StoreHighScore(highGameScore);
        }
    }
        
    void StoreHighScore(int newHighScore) {
        int oldHighScore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighScore > oldHighScore) {
            PlayerPrefs.SetInt("highscore", newHighScore);
        }
        PlayerPrefs.Save();
}
}