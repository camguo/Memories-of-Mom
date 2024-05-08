using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerSO playerSO;
    [SerializeField] Vector3 homePosition;
    // [SerializeField] Vector3 homePosition = new Vector3(0f, -2f, 0f);
    public Vector2 moveVal;
    [SerializeField] public float moveSpeed = 3f;
    public int saveslot;

    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    void OnStartRun()
    {
        moveSpeed = 5f;
    }

    void OnEndRun()
    {
        moveSpeed = 3f;
    }

    // Start is called before the first frame update
    void Start()
    {
        saveslot = PlayerPrefs.GetInt("saveslot");
        if (PlayerPrefs.GetInt("isNew" + saveslot) == 0)
        {
            homePosition = new Vector3(PlayerPrefs.GetFloat("xPos" + saveslot), PlayerPrefs.GetFloat("yPos" + saveslot), 0f);
        }
        else
        {
            homePosition = new Vector3(0f, -2f, 0f);
        }
        // homePosition = new Vector3(PlayerPrefs.GetFloat("xPos" + saveslot), PlayerPrefs.GetFloat("yPos" + saveslot), 0f);
        transform.position = homePosition;
        
        // saveslot = PlayerPrefs.GetInt("saveslot");
        // transform.position.x = PlayerPrefs.GetFloat("s1X" + saveslot);
        // transform.position.y = PlayerPrefs.GetFloat("s1Y" + saveslot);
        
        // transform.position = new Vector3(PlayerPrefs.GetFloat("s1X" + saveSlot), PlayerPrefs.GetFloat("s1Y" + saveSlot), 0f);
    }

    // Update is called once per frame
    void Update()
    {
        // if ((moveVal.x > 0 && moveVal.y > 0) /*UpRight*/
        // || (moveVal.x < 0 && moveVal.y > 0) /*UpLeft*/
        // || (moveVal.x > 0 && moveVal.y < 0) /*DownRight*/
        // || (moveVal.x < 0 && moveVal.y < 0) /*DownLeft*/)
        // {
        //     transform.Translate(new Vector3(moveVal.x, moveVal.y/2, 0) * moveSpeed * Time.deltaTime);
        // }
        
        transform.Translate(new Vector3(moveVal.x, moveVal.y, 0) * moveSpeed * Time.deltaTime);

        
        if (playerSO != null)
        {
            playerSO.position.x = transform.position.x;
            playerSO.position.y = transform.position.y;
        }
    }

    // public void PlayAudio()
    // {
    //     GetComponent<AudioSource>().Play();
    // }

    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     if (other.GetComponent<Ginger>() != null)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         PlayerPrefs.SetInt("gotGinger" + saveslot, 1);
    //         Destroy(other.gameObject);
    //     }

    //     if (other.GetComponent<Pork>() != null)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         PlayerPrefs.SetInt("gotPork" + saveslot, 1);
    //         Destroy(other.gameObject);
    //     }

    //     if (other.GetComponent<Rice>() != null)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         PlayerPrefs.SetInt("gotRice" + saveslot, 1);
    //         Destroy(other.gameObject);
    //     }

    //     if (other.GetComponent<Seasoning>() != null)
    //     {
    //         GetComponent<AudioSource>().Play();
    //         PlayerPrefs.SetInt("gotSeasoning" + saveslot, 1);
    //         Destroy(other.gameObject);
    //     }
    // }
}