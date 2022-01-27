using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongEffektDestroy : MonoBehaviour
{
    public GameObject host;
    void Update()
    {
        if(host == null)
        {
            Destroy(gameObject);
        }
    }
}
