using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Weapon : MonoBehaviour
{
    [SerializeField]
    private WeaponData data;
    private SpriteRenderer sr;

    void Awake() {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            sr.enabled = true;
            data.effect.OnInputStart(gameObject);
        }

        if(Input.GetMouseButtonUp(0)) {
            sr.enabled = false;
            data.effect.OnInputEnd(gameObject);
        }
    }
}
