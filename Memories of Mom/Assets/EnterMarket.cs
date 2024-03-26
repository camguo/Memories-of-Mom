using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterMarket : MonoBehaviour
{
    public Player player;
    [SerializeField] Vector3 toMarket = new Vector3(83f, 51f, 0f);
    [SerializeField] Vector3 toTown = new Vector3(4f, 21f, 0f);
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>();

        if (player != null)
        {
            if (enter)
            {
                player.transform.position = toMarket;
                Debug.Log("entering market");
                enter = false;
            }
            else
            {
                player.transform.position = toTown;
                Debug.Log("leaving market");
                enter = true;
            }
        }
    }
}
