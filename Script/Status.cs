using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour,IDamageble
{
    public static Status instacne;

    void Awake()
    {
        instacne = this;
    }

    public int heartCount = 3;
    public float shield = 0f;

    public void TakeDamage(float damageTaken)
    {
        if(shield > 0f)
        {
            shield -= damageTaken;
            if (shield < 0f) shield = 0f;
        }
        else
        {
            heartCount--;
            if (heartCount < 0) heartCount = 0;
            if(heartCount == 0)
            {
                Dead();
            }
        }
    }

    void Dead()
    {

    }
}

