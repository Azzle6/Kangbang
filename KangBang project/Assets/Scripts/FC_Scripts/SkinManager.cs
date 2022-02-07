using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static SkinManager instance;
    public Sprite sprite;
    
    public List<Sprite> skins;

    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ChangeSkin(int index)
    {
        sprite = skins[index];
    }
}
