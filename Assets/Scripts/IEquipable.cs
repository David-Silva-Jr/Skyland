using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquipable
{  
    void OnInputStart(Object args);
    void OnInputEnd(Object args);
    // void ItemAction();
}
