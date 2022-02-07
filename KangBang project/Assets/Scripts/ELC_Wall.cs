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
            other.gameObject.GetComponent<ELC_Move>().SwitchSide();
            foreach (SpikesZone spike in ELC_GameManager.instance.Spikes)
            {
                spike.GenerateSpikes(3);
            }
            
        }
        else Destroy(other.gameObject);
    }
}
