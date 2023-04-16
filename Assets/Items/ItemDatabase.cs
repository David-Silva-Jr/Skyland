using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Items/Item Database", order = 1)]
public class ItemDatabase : ScriptableObject
{
    [SerializeField]
    public List<ItemData> items = new List<ItemData>();
}
