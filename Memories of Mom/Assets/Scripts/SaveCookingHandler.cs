using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCookingHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveCooking()
    {
        if (PlayerPrefs.GetInt("cookingLevelDone" + 1) == 1 && PlayerPrefs.GetInt("cookingLevelDone" + 2) == 1 && PlayerPrefs.GetInt("cookingLevelDone" + 3) == 1 && PlayerPrefs.GetInt("cookingLevelDone" + 4) == 1)
        {
            PlayerPrefs.SetInt("cookingDone" + PlayerPrefs.GetInt("saveslot"), 1);
        }
    }
}
