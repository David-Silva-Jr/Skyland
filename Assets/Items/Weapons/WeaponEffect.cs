using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponEffect : ScriptableObject, IEquipable
{
    public abstract void OnInputStart(Object args);
    public abstract void OnInputEnd(Object args);
}
