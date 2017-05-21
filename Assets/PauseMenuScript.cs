using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

    public GameObject pauseMenu;
    public GameObject pauseButton;

    void Start() {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void Resume() {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
    }
    public void Pause() {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
    }
    public void Quit() {
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart() {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }
}
