using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlayerSO")]
public class PlayerSO : ScriptableObject
{
    public Vector3 position;
    public int saveslot = 0;
    public int isNew = 1;
}
