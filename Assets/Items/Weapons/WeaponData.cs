using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Items/Weapon")]
public class WeaponData : ItemData
{
    public float baseDamage;
    [SerializeReference]
    public WeaponEffect effect;
}
