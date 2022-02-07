using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UD_BuyingItem : MonoBehaviour
{

    public int itemPrice;


    public void BuyItem(Image skin)
    {
        if(ELC_GlobalManager.instance.Money >= itemPrice)
        {
            ELC_GlobalManager.instance.Money -= itemPrice;
            ELC_GlobalManager.instance.currentSelectedSprite = skin.sprite;
            gameObject.SetActive(false);
        }
        else
        {
            print("tu es pauvre");
        }
        
    }
}
