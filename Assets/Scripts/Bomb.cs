using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] float explodeWait;
    [SerializeField] GameObject explosionRadius;
    [SerializeField] GameObject explodeVFX;
    [SerializeField] AudioClip bombSFX;
    [SerializeField] float volume;
    
    SpriteRenderer mySpriteRenderer;
    void Start()
    {
        StartCoroutine(Explode());
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    IEnumerator Explode()
    {
        yield return new WaitForSeconds(explodeWait);
        AudioSource.PlayClipAtPoint(bombSFX, Camera.main.transform.position, volume);
        Destroy(mySpriteRenderer);
        Instantiate(explosionRadius, transform.position, Quaternion.identity);
        Instantiate(explodeVFX, transform.position, Quaternion.identity);
    }
}
