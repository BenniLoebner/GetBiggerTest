using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyDisplay : MonoBehaviour
{
    TextMeshProUGUI moneyText;
    void Start()
    {
        moneyText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }
        
        moneyText.text = UpgradeManager.instance.money.ToString();
    }
}
