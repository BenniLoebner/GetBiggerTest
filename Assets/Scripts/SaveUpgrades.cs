using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SaveUpgrades : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PrefabUtility.ApplyPrefabInstance(prefab, InteractionMode.AutomatedAction);
    }
}
