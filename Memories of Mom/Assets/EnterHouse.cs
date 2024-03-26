using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{
    public Player player;
    [SerializeField] Vector3 toHome = new Vector3(-52f, -49f, 0f);
    [SerializeField] Vector3 toTown = new Vector3(0f, 0f, 0f);
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>();

        if (player != null)
        {
            if (enter)
            {
                player.transform.position = toHome;
                Debug.Log("entering home");
                enter = false;
            }
            else
            {
                player.transform.position = toTown;
                Debug.Log("leaving home");
                enter = true;
            }
        }
    }
}