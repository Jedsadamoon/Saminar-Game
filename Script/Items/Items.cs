using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public float speed = 5f;
    public float lifeTime = 5f;

    private void Update()
    {
        Life();
        Move();
    }

    void Life()
    {
        if (lifeTime > 0f)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0f) Destroy(gameObject);
        }
    }

    void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            OnCollision();
        }
    }

    public virtual void OnCollision()
    {
        Destroy(gameObject);
    }
}
