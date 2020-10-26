using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [HideInInspector] public GameObject mother; // ทิศทางการยิงหลัก
    Vector3 direction; // ตัวเก็บ ทิศทางการยิง
    public float speed;
    public float damage;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<IDamageble>().TakeDamage(damage);
        Destroy(gameObject);
    }

}
