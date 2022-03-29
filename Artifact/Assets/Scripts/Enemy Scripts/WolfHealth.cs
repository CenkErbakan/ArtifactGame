using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WolfHealth : MonoBehaviour
{
    [SerializeField]
    private GameObject healthUI;

    private float scale;

    [SerializeField]
    private int maxHealth = 100;

    private int currentHealth;

    public Action OnDeath;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        scale = (float)currentHealth / maxHealth;

        healthUI.transform.localScale = new Vector3(scale, healthUI.transform.localScale.y, 1f);

        if (currentHealth <= 0) {
            OnDeath?.Invoke();
            Destroy(gameObject);

       
        }

    }

   




} // class























