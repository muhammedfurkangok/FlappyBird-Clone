using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject SettingsMenu;


    public void Menu()
    {
        SettingsMenu.SetActive(false);
        StartMenu.SetActive(true);
    }
    public void Settings()
    {
        SettingsMenu.SetActive(true);
        StartMenu.SetActive(false);
    }
    public void FlappyFish()
    {
        SceneManager.LoadSceneAsync("FlappyFish");
    }

    public void FlappyBird()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void BackToMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
