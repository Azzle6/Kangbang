using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_Wall : MonoBehaviour
{
    [SerializeField] private bool isKillOnTouch;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isKillOnTouch)
        {
            ELC_GameManager.instance.TouchWall();
        }
        else
        {
            Destroy(other.gameObject);
            ELC_GameManager.instance.PlayerDie();
        }
    }
}
