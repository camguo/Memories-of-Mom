using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public int id;
    public new string name;
    public Sprite icon;
}
