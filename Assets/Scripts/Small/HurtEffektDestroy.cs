using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEffektDestroy : MonoBehaviour
{
    [SerializeField] float waitToDestroy = .125f;
    void Start()
    {
        StartCoroutine(SelfDestroy());
    }

    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(waitToDestroy);
        Destroy(gameObject);
    }
}
