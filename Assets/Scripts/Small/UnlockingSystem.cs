using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockingSystem : MonoBehaviour
{
    [SerializeField] int atLevelIndex;
    [SerializeField] int Index = 0;

    Button myButton;

    // Start is called before the first frame update
    void Start()
    {
        myButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Index == 0)
        {
            if(UpgradeManager.instance.finishedLevel >= atLevelIndex)
            {
                myButton.interactable = true;
            }
            else
            {
                myButton.interactable = false;
            }
        }
        
        if(Index == 1)
        {
            if(UpgradeManager.instance.finishedObstacleLevel >= atLevelIndex)
            {
                myButton.interactable = true;
            }
            else
            {
                myButton.interactable = false;
            }
        }       
    }
}
