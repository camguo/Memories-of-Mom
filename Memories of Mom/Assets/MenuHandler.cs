using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene("NewGameScene");
    }

    public void LoadGame()
    {
        Debug.Log("loading save files...");
        // SceneManager.LoadScene("LoadGameScene");
    }

    public void Photos()
    {
        Debug.Log("loading photo album...");
        // SceneManager.LoadScene("PhotoAlbumScene");
    }

    public void Settings()
    {
        Debug.Log("opening settings...");
        // SceneManager.LoadScene("SettingsScene");
    }

    public void Credits()
    {
        Debug.Log("opening credits...");
        SceneManager.LoadScene("CreditsScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void Quit()
    {
        Debug.Log("shutting down...");
        Application.Quit();
    }
}
