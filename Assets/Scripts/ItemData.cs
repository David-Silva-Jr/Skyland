using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "Items/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public float itemValue;
    public string itemDescription;
    public Sprite itemSprite;
}
