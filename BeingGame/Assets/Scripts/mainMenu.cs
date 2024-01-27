using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public GameObject menu, options, loading;
    public string gameSceneName;

    public void openOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }
    public void goBack()
    {
        options.SetActive(false);
        menu.SetActive(true);
    }
    public void quitGame()
    {
        Application.Quit();
    }
    public void playGame()
    {
        menu.SetActive(false);
        PlayerPrefs.Save();
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
}