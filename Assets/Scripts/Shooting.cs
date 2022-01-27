using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float bulletSpeed = 20f;
    public float shootspeed = 3f;
    [SerializeField] AudioClip shootSFX;
    
    Rigidbody2D myRigidbody;
    GameObject bullet; 
    Coroutine shootCoroutine;
    Coroutine doNothingCoroutine;
    Touch touch;

    bool shootActive = true;
    bool allowToShoot = true;

    void Start()
    {
        shootspeed = UpgradeManager.instance.runSpeed;
    }

    void Update()
    {   
        if(Input.touchCount == 0)
        {
            allowToShoot = true;
        }
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (shootActive == true && allowToShoot == true)
            {
                shootCoroutine = StartCoroutine(ShootLong());
                allowToShoot = false;
            }
        }
          
        if (Input.touchCount == 0 && shootActive == true)
        {
            StopCoroutine(shootCoroutine);
            StartCoroutine(MakeShootTrue());
        }
    }

    IEnumerator ShootLong()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(shootspeed);
        }
    }

    IEnumerator MakeShootTrue()
    {
        shootActive = false;
        yield return new WaitForSeconds(.35f);
        shootActive = true;
    }

    private void Shoot()
    {
        AudioSource.PlayClipAtPoint(shootSFX, Camera.main.transform.position);
        bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        myRigidbody = bullet.GetComponent<Rigidbody2D>();
        myRigidbody.AddForce(firePoint.right * bulletSpeed, ForceMode2D.Impulse);
    }
}
