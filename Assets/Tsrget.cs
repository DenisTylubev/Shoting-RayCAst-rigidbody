using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsrget : MonoBehaviour
{
    public float health;
    public void TakeDamage(float amout)
    {
        health -= amout;    
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
}
