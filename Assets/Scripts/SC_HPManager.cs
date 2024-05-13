using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_HPManager : MonoBehaviour
{
    public SC_1UpLimitedUse HpResource;

    public static event Action OnPlayerLoseLife;
    public static event Action OnGameOver;
    private void OnEnable()
    {
        SC_Death.OnSpikeCollision += OnSpikeCollision;
    }

    private void OnDisable()
    {
        SC_Death.OnSpikeCollision -= OnSpikeCollision;
    }
    private void OnSpikeCollision()
    {
        SC_Invincible invincibleRef = GetComponent<SC_Invincible>();
        if(invincibleRef == null || !invincibleRef.IsInvincible)
        {
            Death();
        }
    }
    public void Death()
    {
        OnPlayerLoseLife?.Invoke();
        HpResource.Use();
        if (HpResource.GetObjectCurrentAmount() == 0)
            OnGameOver?.Invoke();
    }
}
