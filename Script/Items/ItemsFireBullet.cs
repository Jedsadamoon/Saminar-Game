using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsFireBullet : Items
{
    public GameObject bullet;

    public override void OnCollision()
    {
        WeaponManager.instance.bulletPrefab = bullet;
        base.OnCollision();
    }
}
