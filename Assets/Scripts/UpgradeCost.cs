using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCost : MonoBehaviour
{
    public float upgradeCostHealth = 10f;
    public float upgradeCostDamage = 10f;
    public float upgradeCostSpeed = 10f;
    public float upgradeCostBoostTime = 10f;
    public float upgradeCostDash = 10f;
    public float upgradeCostRegeneration = 10f;
    public float upgradeCostBombs = 10f;
    [SerializeField] int myIndex;

    Button myButton;
    
    void Start()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        myButton = GetComponent<Button>();
        PlayerPrefs.SetFloat("LastHealth", UpgradeManager.instance.showHealth);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastDamage", UpgradeManager.instance.showDamage);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastSpeed", UpgradeManager.instance.showSpeed);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastBoostTime", UpgradeManager.instance.showBoostTime);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastDash", UpgradeManager.instance.showDash);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastRegeneration", UpgradeManager.instance.showRegeneration);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat("LastBombs", UpgradeManager.instance.showBombs);
        PlayerPrefs.Save();
    }

    void Update()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }
        
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostHealth && myIndex == 0)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostDamage && myIndex == 1)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostSpeed && myIndex == 2)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostBoostTime && myIndex == 3)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostDash && myIndex == 4)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostRegeneration && myIndex == 5)
        {
            myButton.interactable = false;
        }
        if(UpgradeManager.instance.money < UpgradeManager.instance.upgradeCostBombs && myIndex == 6)
        {
            myButton.interactable = false;
        }
        
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostHealth && myIndex == 0)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostDamage && myIndex == 1)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostSpeed && myIndex == 2)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostBoostTime && myIndex == 3)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostDash && myIndex == 4)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostRegeneration && myIndex == 5)
        {
            myButton.interactable = true;
        }
        if(UpgradeManager.instance.money >= UpgradeManager.instance.upgradeCostBombs && myIndex == 6)
        {
            myButton.interactable = true;
        }

        if(UpgradeManager.instance.showHealth > PlayerPrefs.GetFloat("LastHealth") && myIndex == 0)
        {
            SubtractMoneyHealth();
            UpgradeManager.instance.upgradeCostHealth += 10;
            PlayerPrefs.SetFloat("LastHealth", UpgradeManager.instance.showHealth);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showDamage > PlayerPrefs.GetFloat("LastDamage") && myIndex == 1)
        {
            SubtractMoneyDamage();
            UpgradeManager.instance.upgradeCostDamage += 10;
            PlayerPrefs.SetFloat("LastDamage", UpgradeManager.instance.showDamage);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showSpeed > PlayerPrefs.GetFloat("LastSpeed") && myIndex == 2)
        {   
            SubtractMoneySpeed();
            UpgradeManager.instance.upgradeCostSpeed += 10;
            PlayerPrefs.SetFloat("LastSpeed", UpgradeManager.instance.showSpeed);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showBoostTime > PlayerPrefs.GetFloat("LastBoostTime") && myIndex == 3)
        {
            SubtractMoneyBoostTime();
            UpgradeManager.instance.upgradeCostBoostTime += 10;
            PlayerPrefs.SetFloat("LastBoostTime", UpgradeManager.instance.showBoostTime);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showDash > PlayerPrefs.GetFloat("LastDash") && myIndex == 4)
        {
            SubtractMoneyDash();
            UpgradeManager.instance.upgradeCostDash += 10;
            PlayerPrefs.SetFloat("LastDash", UpgradeManager.instance.showDash);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showRegeneration > PlayerPrefs.GetFloat("LastRegeneration") && myIndex == 5)
        {  
            SubtractMoneyRegen();
            UpgradeManager.instance.upgradeCostRegeneration += 10;
            PlayerPrefs.SetFloat("LastRegeneration", UpgradeManager.instance.showRegeneration);
            PlayerPrefs.Save();
        }
        if(UpgradeManager.instance.showBombs > PlayerPrefs.GetFloat("LastBombs") && myIndex == 6)
        {
            SubtractMoneyBombs();
            UpgradeManager.instance.upgradeCostBombs += 10;
            PlayerPrefs.SetFloat("LastBombs", UpgradeManager.instance.showBombs);
            PlayerPrefs.Save();
        }
    }
    public void SubtractMoneyHealth()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostHealth;   
    }

    public void SubtractMoneyDamage()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostDamage;   
    }

    public void SubtractMoneySpeed()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostSpeed;   
    }

    public void SubtractMoneyBoostTime()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostBoostTime;   
    }

    public void SubtractMoneyDash()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostDash;   
    }

    public void SubtractMoneyRegen()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostRegeneration;   
    }

    public void SubtractMoneyBombs()
    {
        if (UpgradeManager.instance == null)
        {
            return;
        }

        UpgradeManager.instance.money -= UpgradeManager.instance.upgradeCostBombs;   
    }

    public float GetHealthCost()
    {
        return UpgradeManager.instance.upgradeCostHealth;
    }
    public float GetDamageCost()
    {
        return UpgradeManager.instance.upgradeCostDamage;
    }
    public float GetSpeedCost()
    {
        return UpgradeManager.instance.upgradeCostSpeed;
    }
    public float GetBoostTimeCost()
    {
        return UpgradeManager.instance.upgradeCostBoostTime;
    }
    public float GetDashCost()
    {
        return UpgradeManager.instance.upgradeCostDash;
    }
    public float GetRegenerationCost()
    {
        return UpgradeManager.instance.upgradeCostRegeneration;
    }
    public float GetBombsCost()
    {
        return UpgradeManager.instance.upgradeCostBombs;
    }
}
