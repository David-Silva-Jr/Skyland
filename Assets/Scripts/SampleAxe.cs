using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SampleAxe : Equipable {
    public float cooldown;
    public float timer;

    SpriteRenderer sr;
    bool active;
    void Start() {
        sr = GetComponent<SpriteRenderer>();
        active = false;
        timer = cooldown;
    }

    public override void OnInputStart(Object gameObject)
    {
        sr.enabled = true;
        active = true;
    }

    public override void OnInputEnd(Object gameObject)
    {
        sr.enabled = false;
        active = false;
    }

    void Update() {
        if(timer > 0f) {
            timer -= Time.deltaTime;
        }
        else {
            if(active) {
                Debug.Log("Action");
                timer += cooldown;
            }
        }
    }

    // public override void ItemAction() {
    //     Debug.Log("Action");
    // }    
}
