using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ELC_GameManager : MonoBehaviour
{
    public static ELC_GameManager instance;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
}
