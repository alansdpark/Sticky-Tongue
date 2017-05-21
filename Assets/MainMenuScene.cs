using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour {

	// Use this for initialization
    public void Play() {
        SceneManager.LoadScene("GameScene");
    }
    public void Quit() {
        Application.Quit();
    }
}
