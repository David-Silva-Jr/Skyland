using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipable : MonoBehaviour, IEquipable
{   
    public abstract void OnInputStart(Object args);
    public abstract void OnInputEnd(Object args);
    // public abstract void ItemAction();
}
