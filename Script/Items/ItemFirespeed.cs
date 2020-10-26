using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFirespeed : Items
{
    public float firespeedBonus = 0.5f;

    public override void OnCollision()
    {
        WeaponManager.instance.ModiflyFirespeed(firespeedBonus);
        base.OnCollision();
    }
}
