using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PickUp : MonoBehaviour
{
    Collider2D myCollider2D;
  
    public void Start()
    {
        myCollider2D = GetComponent<Collider2D>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
