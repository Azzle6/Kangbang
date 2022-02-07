using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_Bonbon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        
            ELC_GlobalManager.instance.Money += ELC_GameManager.instance.SettingsSO.BonbonsValue;
            ELC_GameManager.instance.SpawnBonbon();
            Destroy(this.gameObject);
        
    }
}
