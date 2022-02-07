using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ELC_GameManager : MonoBehaviour
{
    public static ELC_GameManager instance;

    [HideInInspector] public int CurrentScore;
    [HideInInspector] public int CurrentMoney;
    
    [SerializeField] public GeneralSettings SettingsSO;
    
    public GameObject PlayerPrefab;
    public GameObject PlayerSpawnPosition;
    public List<SpikesZone> Spikes = new List<SpikesZone>(); //Mettre celui de droite en 1er et celui de gauche en 2ème position
    public GameObject ScoreGO;
    public GameObject GameOverMenu;
    public GameObject BonbonTemplate;
    public GameObject[] BonbonSpawns;

    public int CurrentPhase;
    
    private GameObject Player;
    private AudioManager audioManager;

    private void Awake()
    {
        if (instance != null) return;
        
        instance = this;
        //DontDestroyOnLoad(this.gameObject);
        
    }

    private void Start()
    {
        audioManager = AudioManager.instance;
        
        StartGame();
    }

    public void StartGame()
    {
        Player = Instantiate(PlayerPrefab, PlayerSpawnPosition.transform);
        SpawnBonbon();
    }

    public void AddScore()
    {
        CurrentScore += SettingsSO.ScoreBumpWall;
        ScoreGO.GetComponent<TMP_Text>().text = "Score : " + CurrentScore;
    }

    public void PlayerDie()
    {
        audioManager.Play("Mort");
        Destroy(Player);
        GameOverMenu.SetActive(true);
        CurrentScore = 0;
    }

    public void TouchWall()
    {
        ELC_Move moveScript =Player.GetComponent<ELC_Move>();
        moveScript.SwitchSide();
        AddScore();
        CurrentPhase++;
        
        
        for (int i = SettingsSO.LevelsSettings.Length - 1; i >= 0; i--)
        {
            Debug.Log(CurrentPhase);
            if (SettingsSO.LevelsSettings[i].BeginAtPhase < CurrentPhase)
            {
                if (moveScript.movingSide == 1)
                {
                    Spikes[0].GenerateSpikes(Random.Range(SettingsSO.LevelsSettings[i].SpikesMinNumbers,SettingsSO.LevelsSettings[i].SpikesMaxNumbers + 1));
                }
                else Spikes[1].GenerateSpikes(Random.Range(SettingsSO.LevelsSettings[i].SpikesMinNumbers,SettingsSO.LevelsSettings[i].SpikesMaxNumbers + 1));

                Debug.Log("passe");
                break;
            }
        }
    }

    public void SpawnBonbon()
    {
        Instantiate(BonbonTemplate, BonbonSpawns[Random.Range(0, BonbonSpawns.Length - 1)].transform);
    }
}
