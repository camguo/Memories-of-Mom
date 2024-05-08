using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CookingUI : MonoBehaviour
{
    // public static CookingUI instance;

    // private int scoreValue;

    // [SerializeField] private GameObject retryButton;
    // [SerializeField] ProgressBar progressBar;
    // [SerializeField] BagWindow levelSelector;
    
    // [SerializeField] AudioClip audioClip;
    // [SerializeField] AudioSource audioSource;

    // public QTEKey[] qteKeys;

    // [SerializeField] float minRandomX = -8.5f;
    // [SerializeField] float maxRandomX = 8.5f;
    // [SerializeField] float minRandomY = 0f;
    // [SerializeField] float maxRandomY = 5f;

    // [SerializeField] float level1G = 0.0f;
    // [SerializeField] float level2G = 0.1f;
    // [SerializeField] float level3G = 0.2f;
    // [SerializeField] float level4G = 0.3f;
    // private float pauseTime;

    // private void Awake()
    // {
    //     instance = this;
    // }
    // // Start is called before the first frame update
    // void Start()
    // {
    //     qteKeys = GetComponentsInChildren<QTEKey>(true);
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if (progressBar.percentage >= 1f)
    //     {
    //         Debug.Log("progress bar at 100");
    //         levelSelector.gameObject.SetActive(true);
    //         StopCoroutine("SpawnQTEKeysRoutine");
    //     }
    // }

    // public void StartCookingL1()
    // {
    //     pauseTime = 2f;
    //     OpenQTEUI(1);
    // }

    // public void StartCookingL2()
    // {
    //     pauseTime = 1.5f;
    //     OpenQTEUI(2);
    // }

    // public void StartCookingL3()
    // {
    //     pauseTime = 1f;
    //     OpenQTEUI(3);
    // }

    // public void StartCookingL4()
    // {
    //     pauseTime = 0.5f;
    //     OpenQTEUI(4);
    // }

    // public void OpenQTEUI(int level)
    // {
        
    //     PlayerPrefs.SetInt("cookingLevel", level);
    //     // while (progressBar.percentage < 1f)
    //     // {
    //     foreach (QTEKey key in qteKeys)
    //     {
    //         key.gameObject.SetActive(true);

    //         if (level == 4)
    //         {
    //             key.gameObject.GetComponent<Rigidbody2D>().gravityScale = level4G;
    //         }
    //         else if (level == 3)
    //         {
    //             key.gameObject.GetComponent<Rigidbody2D>().gravityScale = level3G;
    //         }
    //         else if (level == 2)
    //         {
    //             key.gameObject.GetComponent<Rigidbody2D>().gravityScale = level2G;
    //         }
    //         else
    //         {
    //             key.gameObject.GetComponent<Rigidbody2D>().gravityScale = level1G;
    //         }

    //         float randomX = Random.Range(minRandomX,maxRandomX);
    //         float randomY = Random.Range(minRandomY,maxRandomY);

    //         key.transform.position = new Vector2(randomX, randomY);
            
    //         // if (progressBar.percentage < 1f)
    //         // {
    //         //     Debug.Log("spawning keys again in " + pauseTime + " seconds");
    //         //     StartCoroutine(PauseQTEKeySpawn(pauseTime));
    //         // }
    //         // else
    //         // {
    //         //     Debug.Log("level complete!");
    //         // }
    //     }
    //     // }
        
    // }

    // // public void StartL1Spawn()
    // // {
    // //     StopAllCoroutines();
    // //     qteKey.GetComponent<Rigidbody2D>().gravityScale = level1G;

    // //     StartCoroutine(SpawnL1QTEKeysRoutine());
        
    // // }

    // IEnumerator PauseQTEKeySpawn(float pauseTime)
    //     {
    //         yield return new WaitForSeconds(pauseTime);
    //         OpenQTEUI(PlayerPrefs.GetInt("cookingLevel"));
    //         Debug.Log("spawning L1 keys...");
    //     }
}
