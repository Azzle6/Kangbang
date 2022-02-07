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
    public GameObject ScoreGO;

    private void Awake()
    {
        if(instance == null) instance = this;
    }


    public void AddScore(int scoreToAdd)
    {
        CurrentScore += scoreToAdd;
    }
}
