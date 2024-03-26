using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterCave : MonoBehaviour
{
    public Player player;
    [SerializeField] Vector3 toCave = new Vector3(-74f, 16f, 0f);
    [SerializeField] Vector3 toTown = new Vector3(-37f, 21f, 0f);
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>();

        if (player != null)
        {
            if (enter)
            {
                player.transform.position = toCave;
                Debug.Log("entering cave");
                enter = false;
            }
            else
            {
                player.transform.position = toTown;
                Debug.Log("leaving cave");
                enter = true;
            }
        }
    }
}
