using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UD_CurrentMoneyCounter : MonoBehaviour
{
    TMP_Text counterText;


    void Start()
    {
        counterText = GetComponent<TMP_Text>();
    }


    void Update()
    {
        counterText.text = "Current Money " + ELC_GlobalManager.instance.Money.ToString();
    }
}
