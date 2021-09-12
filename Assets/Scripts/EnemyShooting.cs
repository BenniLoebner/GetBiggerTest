using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 20f;
    public float shootWaitTime = 5f;
    [SerializeField] AudioClip enemyShootSFX;
    [SerializeField] float shootVolume = 3f;

    bool canShoot;

    Enemy myEnemy;
    Rigidbody2D myRigidbody;
    GameObject bullet;

    void Start()
    {
        myEnemy = GetComponent<Enemy>();
        
        StartCoroutine(ShootWait());
    }

    void Update()
    {
        canShoot = myEnemy.GetShootingAllowed();
    }

    IEnumerator ShootWait()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(shootWaitTime);
        }
    }
    private void Shoot()
    {
        if(canShoot == true)
        {
            AudioSource.PlayClipAtPoint(enemyShootSFX, Camera.main.transform.position, shootVolume);
            bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            myRigidbody = bullet.GetComponent<Rigidbody2D>();
            myRigidbody.AddForce(-transform.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
