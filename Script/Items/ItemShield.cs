using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemShield : Items
{
    public float shieldBonus;

    public override void OnCollision()
    {
        Status.instacne.shield += shieldBonus;
        base.OnCollision();
    }
}
