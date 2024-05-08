using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QTEKeyClicked : MonoBehaviour
{
    public GameObject qteKey;
    [SerializeField] ProgressBar progressBar;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    
    void KeyClicked()
    {
        gameObject.SetActive(false);
        // Destroy(gameObject,2);
    }

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(audioClip);
        progressBar.UpdateProgressBar(1);
        // qteKey.GetComponent<TextMeshProUGUI>() = ("Success!");
        KeyClicked();
    }
}
