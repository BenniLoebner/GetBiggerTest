using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysPerLevel : MonoBehaviour
{
    [SerializeField] int keysPerLevel;

    public int GetKeysPerLevel()
    {
        return keysPerLevel;
    }
}
