using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody projectileBody;
    private float damage = 1f;

    public void Initialize(Vector3 direction)
    {
        //initializes the projectile
        projectileBody.AddForce(direction);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        // use tag to see if a player was hit by the projectile
        if (collision.transform.CompareTag("Player"))
        {
            collision.collider.gameObject.GetComponent<HealthBar>().wasHit(damage);
        }
    }
}

