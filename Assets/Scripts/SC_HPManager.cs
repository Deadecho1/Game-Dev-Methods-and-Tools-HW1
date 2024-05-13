using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_HPManager : MonoBehaviour
{
    public Resource HpResource;

    public static event Action OnPlayerGainLife;
    public static event Action OnPlayerLoseLife;
    public static event Action OnGameOver;
    private void OnEnable()
    {
        SC_Death.OnSpikeCollision += OnSpikeCollision;
        SC_HealthPickup.OnHealthPickupCollision += OnHealthPickupCollision;
    }

    private void OnDisable()
    {
        SC_Death.OnSpikeCollision -= OnSpikeCollision;
        SC_HealthPickup.OnHealthPickupCollision -= OnHealthPickupCollision;
    }
    private void OnSpikeCollision()
    {
        SC_Invincible invincibleRef = GetComponent<SC_Invincible>();
        if(invincibleRef == null || !invincibleRef.IsInvincible)
        {
            Death();
        }
    }
    private void OnHealthPickupCollision(int amount)
    {
        OnPlayerGainLife?.Invoke();
        HpResource.AddObject(amount);
    }

    public void Death()
    {
        OnPlayerLoseLife?.Invoke();
        HpResource.Use();
        if (HpResource.GetObjectCurrentAmount() == 0)
            OnGameOver?.Invoke();
    }
}
