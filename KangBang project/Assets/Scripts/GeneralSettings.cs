using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0, fileName = "GlobalSettings", menuName = "ScriptableObjects/GlobalSettings")]
public class GeneralSettings : ScriptableObject
{
    public int BonbonsValue;
    public int ScoreBumpWall;
    public LevelParameter[] LevelsSettings;
    public float GravityToAdd;
    public float SpeedToAdd;
}

[System.Serializable]
public class LevelParameter
{
    public int BeginAtPhase;
    public int SpikesMinNumbers;
    public int SpikesMaxNumbers;
    
    [Range(0,100)]
    public float BonbonsSummonChance;
}
