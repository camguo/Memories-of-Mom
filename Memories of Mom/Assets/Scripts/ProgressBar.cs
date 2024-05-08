using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    public static ProgressBar instance;
    public Transform foregroundTransform;
    public Transform catchupTransform;
    public float catchupSpeed = 10.0f;
    
    [Range(0f,1f)]
    public float percentage = 0.5f;

    private void Awake()
    {
        instance = this;
    }
    
    void Update(){
        foregroundTransform.localScale = new Vector3(percentage,1f,1f);

        float catchupSize = Mathf.Lerp(catchupTransform.localScale.x, percentage, Time.deltaTime*catchupSpeed);
        if(catchupSize < percentage){
            catchupSize = percentage;
        }
        catchupTransform.localScale = new Vector3(catchupSize,1.0f,1.0f);

        if (percentage < 0f)
        {
            percentage = 0f;
            SceneManager.LoadScene("CookingScene");
        }

        if (percentage > 1f)
        {
            percentage = 1f;
            PlayerPrefs.SetInt("cookingLevelDone" + PlayerPrefs.GetInt("cookingLevel"), 1);
        }
    }

    public void ResetBar()
    {
        percentage = 0.5f;
    }
    
    public void UpdateProgressBar(int change)
    {
        int level = PlayerPrefs.GetInt("cookingLevel");

        if (level == 4)
        {
            percentage += change * 0.1f;
        }
        else if (level == 3)
        {
            percentage += change * 0.08f;
        }
        else if (level == 2)
        {
            percentage += change * 0.06f;
        }
        else if (level == 1)
        {
            percentage += change * 0.04f;
        }
    }
}
