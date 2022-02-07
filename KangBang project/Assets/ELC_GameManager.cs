using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ELC_GameManager : MonoBehaviour
{
    public static ELC_GameManager instance;

    [HideInInspector] public int CurrentScore;
    [HideInInspector] public int CurrentMoney;
    public GameObject ScoreGO;

    private void Awake()
    {
        if (instance != null) return;
        
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        
    }


    public void AddScore(int scoreToAdd)
    {
        CurrentScore += scoreToAdd;
    }

    public void PlayerDie()
    {
        CurrentScore = 0;
    }
    
}
