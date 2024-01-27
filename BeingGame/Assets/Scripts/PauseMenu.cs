using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenuobj, optionsmenu;
    //public PlayerController player;
    public bool isPaused;
    public string mainMenuSceneName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused == true)
            {
                //player.enabled = false;
                pausemenuobj.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                AudioListener.pause = true;
            }
            if (isPaused == false)
            {
                //player.enabled = true;
                pausemenuobj.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                AudioListener.pause = false;
            }
        }
    }
    public void resumeGame()
    {
        //player.enabled = true;
        pausemenuobj.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        AudioListener.pause = false;
        isPaused = false;
    }
    public void openOptions()
    {
        pausemenuobj.SetActive(false);
        optionsmenu.SetActive(true);
    }

    public void goBack()
    {
        pausemenuobj.SetActive(true);
        optionsmenu.SetActive(false);
    }
    public void backToMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("quit game");
    }
}