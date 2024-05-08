using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void EnterGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void EnterCooking()
    {
        SceneManager.LoadScene("CookingScene");
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
