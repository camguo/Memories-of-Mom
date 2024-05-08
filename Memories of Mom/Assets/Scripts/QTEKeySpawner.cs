using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QTEKeySpawner : MonoBehaviour
{
    [SerializeField] GameObject qteKey;
    GameObject newQTEKey;
    Rigidbody2D qteKeyRb;

    [SerializeField] ProgressBar progressBar;
    [SerializeField] BagWindow levelSelector;
    [SerializeField] GameObject successTP;

    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;

    [SerializeField] float minRandomX = -8.5f;
    [SerializeField] float maxRandomX = 8.5f;
    [SerializeField] float minRandomY = 0f;
    [SerializeField] float maxRandomY = 5f;

    [SerializeField] float level1G = 0.0f;
    [SerializeField] float level2G = 0.25f;
    [SerializeField] float level3G = 0.5f;
    [SerializeField] float level4G = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        // qteKeyRb = qteKey.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (progressBar.percentage >= 1f)
        {
            Debug.Log("progress bar at 100");
            successTP.SetActive(true);
            levelSelector.gameObject.SetActive(true);
            StopAllCoroutines();
        }
    }

    void SpawnQTEKeys()
    {
        Debug.Log("spawning keys...");
        levelSelector.gameObject.SetActive(false);
        float randomX = Random.Range(minRandomX,maxRandomX);
        float randomY = Random.Range(minRandomY,maxRandomY);

        newQTEKey = Instantiate(qteKey, new Vector3(randomX, randomY, 0f), Quaternion.identity);
        newQTEKey.SetActive(true);
        // if (keyClicked.clicked == true)
        // {
        //     progressBar.UpdateProgressBar(newQTEKey, 1);
        // }
        // else
        // {
        //     progressBar.UpdateProgressBar(newQTEKey, -1);
        // }
        Destroy(newQTEKey,2);

        progressBar.percentage -= 0.02f;
    }

    public void StartL1Spawn()
    {
        PlayerPrefs.SetInt("cookingLevel", 1);
        StopAllCoroutines();
        qteKey.GetComponent<Rigidbody2D>().gravityScale = level1G;

        StartCoroutine(SpawnL1QTEKeysRoutine());
        IEnumerator SpawnL1QTEKeysRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(2f);
                SpawnQTEKeys();
                Debug.Log("spawning L1 keys...");
            }
        }
    }

    public void StartL2Spawn()
    {
        PlayerPrefs.SetInt("cookingLevel", 2);
        StopAllCoroutines();
        qteKey.GetComponent<Rigidbody2D>().gravityScale = level2G;

        StartCoroutine(SpawnL2QTEKeysRoutine());
        IEnumerator SpawnL2QTEKeysRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.5f);
                Debug.Log("spawning L2 keys...");
                SpawnQTEKeys();
            }
        }
    }

    public void StartL3Spawn()
    {
        PlayerPrefs.SetInt("cookingLevel", 3);
        StopAllCoroutines();
        qteKey.GetComponent<Rigidbody2D>().gravityScale = level3G;

        StartCoroutine(SpawnL3QTEKeysRoutine());
        IEnumerator SpawnL3QTEKeysRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1f);
                Debug.Log("spawning L3 keys...");
                SpawnQTEKeys();
            }
        }
    }

    public void StartL4Spawn()
    {
        PlayerPrefs.SetInt("cookingLevel", 4);
        StopAllCoroutines();
        qteKey.GetComponent<Rigidbody2D>().gravityScale = level4G;

        StartCoroutine(SpawnL4QTEKeysRoutine());
        IEnumerator SpawnL4QTEKeysRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(0.5f);
                Debug.Log("spawning L4 keys...");
                SpawnQTEKeys();
            }
        }
    }
}
