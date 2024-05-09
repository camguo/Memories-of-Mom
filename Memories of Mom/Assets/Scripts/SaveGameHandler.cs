using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameHandler : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    [SerializeField] Player player;
    public int saveslot;
    // Start is called before the first frame update
    void Start()
    {
        // saveslot = PlayerPrefs.GetInt("saveslot");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void saveGame()
    {
        saveslot = PlayerPrefs.GetInt("saveslot");

        PlayerPrefs.SetInt("isNew" + saveslot, 0);

        PlayerPrefs.SetFloat("xPos" + saveslot, player.transform.position.x);
        PlayerPrefs.SetFloat("yPos" + saveslot, player.transform.position.y);

        if (playerSO != null)
        {
            playerSO.position.x = player.transform.position.x;
            playerSO.position.y = player.transform.position.y;
            playerSO.isNew = 0;
        }

        Debug.Log(PlayerPrefs.GetFloat("xPos" + saveslot) + ", " + PlayerPrefs.GetFloat("yPos" + saveslot));

        PlayerPrefs.Save();
    }
}
