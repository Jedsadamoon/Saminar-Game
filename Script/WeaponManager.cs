using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public static WeaponManager instance;

    private void Awake()
    {
        instance = this;
    }

    public GameObject bulletPrefab;
    public float maxFirespeed = 8f;

    [SerializeField] private float firespeed = 0.5f;
    public float FireSpeed() { return firespeed; }

    public float bulletLifeTime = 10f;

    public void ModiflyFirespeed(float bonus)
    {
        firespeed += bonus;
        if (firespeed > maxFirespeed) firespeed = maxFirespeed;
        if (firespeed < 0f) firespeed = 0f;
    }

}
