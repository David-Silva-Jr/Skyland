using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicSwordEffect", menuName = "Weapon Effects/Basic Sword")]
public class BasicSwordEffect : WeaponEffect
{
    [Min(0.001f)]
    public float swingTime;
    public float swingArc;

    private GameObject weaponObject;

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnInputStart(Object gameObject) {
        
    }

    public override void OnInputEnd(Object gameObject) {

    }
}
