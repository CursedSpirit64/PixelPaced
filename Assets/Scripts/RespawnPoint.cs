﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        //Player.transform.position = respawnPoint.transform.position;
        Instantiate(hoard, new Vector2(other.transform.position.x, other.transform.position.y), Quaternion.identity);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
