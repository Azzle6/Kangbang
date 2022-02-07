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
    [SerializeField] private GeneralSettings SettingsSO;
    public GameObject PlayerPrefab;
    public GameObject PlayerSpawnPosition;
    public List<SpikesZone> Spikes = new List<SpikesZone>(); //Mettre celui de droite en 1er et celui de gauche en 2ème position
    public GameObject ScoreGO;

    private GameObject Player;

    private void Awake()
    {
        if (instance != null) return;
        
        instance = this;
        DontDestroyOnLoad(this.gameObject);
        
    }

    private void Start()
    {
        StartGame();
    }

    public void StartGame()
    {
        Player = Instantiate(PlayerPrefab, PlayerSpawnPosition.transform);
    }

    public void AddScore()
    {
        CurrentScore += SettingsSO.ScoreBumpWall;
        ScoreGO.GetComponent<TMP_Text>().text = "Score : " + CurrentScore;
    }

    public void PlayerDie()
    {
        Destroy(Player);
        CurrentScore = 0;
    }
    
}
