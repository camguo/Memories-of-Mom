using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRanch : MonoBehaviour
{
    public Player player;
    [SerializeField] Vector3 toRanch = new Vector3(10f, -41f, 0f);
    [SerializeField] Vector3 toTown = new Vector3(11f, -7f, 0f);
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>();

        if (player != null)
        {
            if (enter)
            {
                player.transform.position = toRanch;
                Debug.Log("entering ranch");
                enter = false;
            }
            else
            {
                player.transform.position = toTown;
                Debug.Log("leaving ranch");
                enter = true;
            }
        }
    }
}
