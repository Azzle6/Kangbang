using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public string playerTag;
    private ELC_GameManager gameManager;

    private void Start()
    {
        gameManager = ELC_GameManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(playerTag))
        {
            gameManager.PlayerDie();
        }
    }
}
