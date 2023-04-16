using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleEquip : MonoBehaviour
{   
    public Equipable equipped;

    void Update() {
        // equipped.sr.enabled = Input.GetMouseButton(0);
        equipped.transform.position = transform.position;
        if(Input.GetMouseButtonDown(0)) {
            equipped.OnInputStart(gameObject);
        }

        if(Input.GetMouseButtonUp(0)) {
            equipped.OnInputEnd(gameObject);
        }
    }
}
