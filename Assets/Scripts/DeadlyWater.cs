using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyWater : MonoBehaviour
{

    public float health;
    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        
    }
}
