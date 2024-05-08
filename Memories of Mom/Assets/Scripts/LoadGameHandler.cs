using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadGameHandler : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    public int saveslot;

    [Header("Save Slot 1")]
    [SerializeField] private TextMeshProUGUI s1XPos;
    [SerializeField] private TextMeshProUGUI s1YPos;
    [SerializeField] private TextMeshProUGUI s1ingredientsCollected;
    [SerializeField] private TextMeshProUGUI s1cookingDone;

    [Header("Save Slot 2")]
    [SerializeField] private TextMeshProUGUI s2XPos;
    [SerializeField] private TextMeshProUGUI s2YPos;
    [SerializeField] private TextMeshProUGUI s2ingredientsCollected;
    [SerializeField] private TextMeshProUGUI s2cookingDone;
    // Start is called before the first frame update
    void Start()
    {
        // saveslot = PlayerPrefs.GetInt("saveslot");
        s1XPos.text = (PlayerPrefs.GetFloat("xPos" + 1)).ToString("#.##");
        s1YPos.text = (PlayerPrefs.GetFloat("yPos" + 1)).ToString("#.##");
        s1ingredientsCollected.text = (PlayerPrefs.GetInt("Ginger" + 1) + PlayerPrefs.GetInt("Pork" + 1) + PlayerPrefs.GetInt("Rice" + 1) + PlayerPrefs.GetInt("Seasoning" + 1)).ToString("0");
        if (PlayerPrefs.GetInt("cookingDone" + 1) == 1)
        {
            s1cookingDone.text = "Yes";
        }
        else
        {
            s1cookingDone.text = "No";
        }

        s2XPos.text = (PlayerPrefs.GetFloat("xPos" + 2)).ToString("#.##");
        s2YPos.text = (PlayerPrefs.GetFloat("yPos" + 2)).ToString("#.##");
        s2ingredientsCollected.text = (PlayerPrefs.GetInt("Ginger" + 2) + PlayerPrefs.GetInt("Pork" + 2) + PlayerPrefs.GetInt("Rice" + 2) + PlayerPrefs.GetInt("Seasoning" + 2)).ToString("0");
        
        if (PlayerPrefs.GetInt("cookingDone" + 2) == 1)
        {
            s2cookingDone.text = "Yes";
        }
        else
        {
            s2cookingDone.text = "No";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectSave1()
    {
        PlayerPrefs.SetInt("saveslot", 1);
        
        loadSave();
    }

    public void selectSave2()
    {
        PlayerPrefs.SetInt("saveslot", 2);
        
        loadSave();
    }

    void loadSave()
    {
        if (PlayerPrefs.GetInt("Ginger" + 1) + PlayerPrefs.GetInt("Pork" + 1) + PlayerPrefs.GetInt("Rice" + 1) + PlayerPrefs.GetInt("Seasoning" + 1) == 4 ||
            PlayerPrefs.GetInt("Ginger" + 2) + PlayerPrefs.GetInt("Pork" + 2) + PlayerPrefs.GetInt("Rice" + 2) + PlayerPrefs.GetInt("Seasoning" + 2) == 4)
            {
                SceneManager.LoadScene("CookingScene");
            }

        saveslot = PlayerPrefs.GetInt("saveslot");

        if (playerSO != null)
        {
            playerSO.saveslot = saveslot;
            playerSO.position.x = PlayerPrefs.GetFloat("xPos" + saveslot);
            playerSO.position.y = PlayerPrefs.GetFloat("yPos" + saveslot);
        }

        SceneManager.LoadScene("GameScene");
    }
}
