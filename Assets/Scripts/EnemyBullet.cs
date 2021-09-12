using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] GameObject explodeVFX;
    [SerializeField] float wait = 0.3f;
    [SerializeField] float waitParticles = 0.3f;

    SpriteRenderer mySpriteRenderer;

    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(SelfDestroy());
    }
    IEnumerator SelfDestroy()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.tag == "Wall")
        {
            StartCoroutine(DestroyBullet());
        }

        if (collider2D.tag == "Shredder")
        {
            Destroy(gameObject);
        }

        if (collider2D.tag == "Player")
        {
            StartCoroutine(DestroyBullet());
        }
    }
    IEnumerator DestroyBullet()
    {
        Destroy(mySpriteRenderer);
        StartCoroutine(TriggerExplosionVFX());
        yield return new WaitForSeconds(wait);
        Destroy(gameObject);
    }
    IEnumerator TriggerExplosionVFX()
    {
        GameObject particles = Instantiate(explodeVFX, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(waitParticles);
        Destroy(particles);
    }
}
