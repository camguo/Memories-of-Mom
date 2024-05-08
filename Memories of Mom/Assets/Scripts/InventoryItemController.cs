using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    public Item item;

    public Button RemoveItemButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        PlayerPrefs.SetInt(item.name + PlayerPrefs.GetInt("saveslot"), 0);
        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }
}
