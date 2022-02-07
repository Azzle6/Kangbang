using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_Wall : MonoBehaviour
{
    private bool isKillOnTouch;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!isKillOnTouch)
        {
            

            if (other.gameObject.GetComponent<ELC_Move>().movingSide == 1)
            {
                ELC_GameManager.instance.Spikes[0].GenerateSpikes(3);
            }
            else ELC_GameManager.instance.Spikes[1].GenerateSpikes(3);
            
            
            other.gameObject.GetComponent<ELC_Move>().SwitchSide();
            
            ELC_GameManager.instance.AddScore();
            
        }
        else Destroy(other.gameObject);
    }
}
