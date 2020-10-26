using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float firespeed = 6f;
    public float lifeTime = 5f;
    float firespeedTimer = 0f;

    private void Start()
    {
        firespeedTimer = 1f / firespeed;
    }
    private void Update()
    {
        if (firespeedTimer > 0f)
        {
            firespeedTimer -= Time.deltaTime;
            if (firespeedTimer < 0f) firespeedTimer = 0f;
        }

        if (firespeedTimer <= 0f)
        {
            firespeedTimer = 1 / firespeed;
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        bullet.GetComponent<Bullet>().mother = gameObject;
        Destroy(bullet, lifeTime);
    }
}
