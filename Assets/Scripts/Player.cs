using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{   
    public float hpMax;
    public float hpCurrent;

    // Start is called before the first frame update
    void Awake()
    {
        hpCurrent = hpMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount) {
        hpCurrent -= amount;
    }
}
