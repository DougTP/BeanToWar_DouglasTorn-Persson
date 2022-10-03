using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image Hp;
    [SerializeField] private float maxHealth;
    private float health;

    private void Start()
    {
        // sets the initial health to max
        health = maxHealth;
    }

    public void wasHit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // destroys the character when life hits zero
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
        // shows the health ratio on health bar
        Hp.fillAmount = health / maxHealth;
    }
}
