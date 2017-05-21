using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
    public void Quit() {
        Debug.Log("Player Quit Game");
        Application.Quit();
    }
	
	// Update is called once per frame
    public void Retry() {
        SceneManager.LoadScene("GameScene");
    }


}
