using UnityEngine;

[System.Serializable]
public class UpgradeData
{
    public float runSpeed;
    public int showSpeed;
    public float health;
    public int showHealth;
    public float damage;
    public int showDamage;
    public float boostTime;
    public int showBoostTime;
    public float dashSpeed;
    public int showDash;
    public float bombDamage;
    public int showBombs;
    public float regeneration;
    public int showRegeneration;
    public float coolDownRegeneration;
    public float coolDownBombs;
    public float coolDownDash;
    public float money;
    public float moneyPlus;
    public bool canDash;
    public bool canPlaceBombs;
    public bool canRegenerate;

    public int finishedLevel;
    public int finishedObstacleLevel;

    public float upgradeCostHealth;
    public float upgradeCostDamage;
    public float upgradeCostSpeed;
    public float upgradeCostBoostTime;
    public float upgradeCostDash;
    public float upgradeCostRegeneration;
    public float upgradeCostBombs;
    
    public bool healthMax;
    public bool damageMax;
    public bool speedMax;
    public bool boostTimeMax;
    public bool dashMax;
    public bool bombsMax;
    public bool regenerationMax;

    public UpgradeData(UpgradeManager upgradeManager)
    {
        runSpeed = upgradeManager.runSpeed;
        showSpeed = upgradeManager.showSpeed;
        health = upgradeManager.health;
        showHealth = upgradeManager.showHealth;
        damage = upgradeManager.damage;
        showDamage = upgradeManager.showDamage;
        boostTime = upgradeManager.boostTime;
        showBoostTime = upgradeManager.showBoostTime;
        dashSpeed = upgradeManager.dashSpeed;
        showDash = upgradeManager.showDash;
        bombDamage = upgradeManager.bombDamage;
        showBombs = upgradeManager.showBombs;
        regeneration = upgradeManager.regeneration;
        showRegeneration = upgradeManager.showRegeneration;
        coolDownRegeneration = upgradeManager.coolDownRegeneration;
        coolDownBombs = upgradeManager.coolDownBombs;
        coolDownDash = upgradeManager.coolDownDash;
        money = upgradeManager.money;
        moneyPlus = upgradeManager.moneyPlus;
        canDash = upgradeManager.canDash;
        canPlaceBombs = upgradeManager.canPlaceBombs;
        canRegenerate = upgradeManager.canRegenerate;

        finishedLevel = upgradeManager.finishedLevel;
        finishedObstacleLevel = upgradeManager.finishedObstacleLevel;

        upgradeCostHealth = upgradeManager.upgradeCostHealth;
        upgradeCostDamage = upgradeManager.upgradeCostDamage;
        upgradeCostSpeed = upgradeManager.upgradeCostSpeed;
        upgradeCostBoostTime = upgradeManager.upgradeCostBoostTime;
        upgradeCostDash = upgradeManager.upgradeCostDash;
        upgradeCostRegeneration = upgradeManager.upgradeCostRegeneration;
        upgradeCostBombs = upgradeManager.upgradeCostBombs;
        healthMax = upgradeManager.healthMax;
        damageMax = upgradeManager.damageMax;
        speedMax = upgradeManager.speedMax;
        boostTimeMax = upgradeManager.boostTimeMax;
        dashMax = upgradeManager.dashMax;
        bombsMax = upgradeManager.bombsMax;
        regenerationMax = upgradeManager.regenerationMax;
    }
}