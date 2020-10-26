using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeart : Items
{
    public int heartBonus;

    public override void OnCollision()
    {
        Status.instacne.heartCount += heartBonus;
        base.OnCollision();
    }
}
