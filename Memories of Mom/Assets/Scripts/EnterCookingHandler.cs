using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterCookingHandler : MonoBehaviour
{
    public Item item;

    private void OnMouseDown()
    {
        SceneManager.LoadScene("CookingScene");
    }
}
