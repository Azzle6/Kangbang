using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_GlobalManager : MonoBehaviour
{
    public static ELC_GlobalManager instance;
    public Sprite currentSelectedSprite;
    public int Money;

    private void Awake()
    {
        if(instance != null) return;

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
