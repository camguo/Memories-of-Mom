using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    
    void Pickup()
    {
        InventoryManager.Instance.Add(item);
        PlayerPrefs.SetInt(item.name + PlayerPrefs.GetInt("saveslot"), 1);
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        audioSource.PlayOneShot(audioClip);
        Pickup();
    }
}
