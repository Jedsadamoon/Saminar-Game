using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    float firespeedTimer = 0f;

    private void Start()
    {
        firespeedTimer = 1f / WeaponManager.instance.FireSpeed();
    }
    private void Update()
    {
        if(firespeedTimer > 0f)
        {
            firespeedTimer -= Time.deltaTime;
            if (firespeedTimer < 0f) firespeedTimer = 0f; 
        }

        if(firespeedTimer <= 0f)
        {
            firespeedTimer = 1 / WeaponManager.instance.FireSpeed();
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(WeaponManager.instance.bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Bullet>().mother = gameObject;
        Destroy(bullet, WeaponManager.instance.bulletLifeTime);
    }
}
