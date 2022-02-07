using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(order = 0, fileName = "GlobalSettings", menuName = "ScriptableObjects/GlobalSettings")]
public class GeneralSettings : ScriptableObject
{
    public int BonbonsValue;
    public LevelParameter[] LevelsSettings;
}

[System.Serializable]
public class LevelParameter
{
    public int SpikesNumbers;
    public float GravityStrength;
    public float SpeedMultiplicator;
}
