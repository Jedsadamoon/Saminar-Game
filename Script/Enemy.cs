using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour,IDamageble
{
    [Header("Status")]
    public float health = 100f;
    public float shield = 50f;
    public float collisionDamage = 40f;
    public float speed = 6f;

   

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    public void TakeDamage(float damageTaken)
    {
        if (shield > 0)
        {
            shield -= damageTaken;
            if (shield < 0f) shield = 0f;
        }
        else
        {
            health -= damageTaken;
            if (health <= 0f)
            {
                health = 0f;
                Dead();
            }
        }
    }

    void Dead()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Status.instacne.TakeDamage(collisionDamage);
            Destroy(gameObject);
        }
    }
}
