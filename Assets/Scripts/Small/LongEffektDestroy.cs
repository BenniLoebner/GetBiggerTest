using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongEffektDestroy : MonoBehaviour
{
    public GameObject host;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(host == null)
        {
            Destroy(gameObject);
        }
    }
}
