using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager instance;
    public float runSpeed = 25f;
    public int showSpeed = 1;
    public float health = 1;
    public int showHealth = 1;
    public float damage = 1;
    public int showDamage = 1;
    public float boostTime = 5f;
    public int showBoostTime = 1;
    public float dashSpeed = 50f;
    public int showDash = 1;
    public float bombDamage = 5f;
    public int showBombs = 1;
    public float regeneration = 2f;
    public int showRegeneration = 1;
    public float coolDownRegeneration = 60f;
    public float coolDownBombs = 60f;
    public float coolDownDash = 60f;
    public float money = 0;
    public float moneyPlus = 0;
    public bool canDash = false;
    public bool canPlaceBombs = false;
    public bool canRegenerate = false;

    public int finishedLevel = 0;
    public int finishedObstacleLevel = 0;

    public float upgradeCostHealth = 10f;
    public float upgradeCostDamage = 10f;
    public float upgradeCostSpeed = 10f;
    public float upgradeCostBoostTime = 10f;
    public float upgradeCostDash = 10f;
    public float upgradeCostRegeneration = 10f;
    public float upgradeCostBombs = 10f;
    
    public bool healthMax = false;
    public bool damageMax = false;
    public bool speedMax = false;
    public bool boostTimeMax = false;
    public bool dashMax = false;
    public bool bombsMax = false;
    public bool regenerationMax = false;
    Player player;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if(instance == null)
        {
            instance = this;
        }
        if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        player = FindObjectOfType<Player>();
    }
}
