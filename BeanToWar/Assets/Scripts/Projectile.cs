using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    private float damage = 1f;

    public void Initialize(Vector3 direction)
    {
        projectileBody.AddForce(direction);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.collider.gameObject.GetComponent<HealthBar>().wasHit(damage);
        }
    }
}

