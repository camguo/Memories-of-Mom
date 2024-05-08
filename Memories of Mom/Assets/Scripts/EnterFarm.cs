using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterFarm : MonoBehaviour
{
    public Player player;
    [SerializeField] Vector3 toFarm = new Vector3(10f, -41f, 0f);
    [SerializeField] Vector3 toTown = new Vector3(11f, -7f, 0f);
    public bool enter = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        player = other.GetComponent<Player>();

        if (player != null)
        {
            if (enter)
            {
                player.transform.position = toFarm;
                Debug.Log("entering farm");
                enter = false;
            }
            else
            {
                player.transform.position = toTown;
                Debug.Log("leaving farm");
                enter = true;
            }
        }
    }
}
