using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamagable
{
    public void TakeDamage(float amount) {
        Debug.Log($"Example monster takes {amount} damage!");
    }
}
