using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AxeLimitedUse : MonoBehaviour, IPickableUsableObject
{
    public SC_AxeWeapon axeWeapon;
    public int objectAmount = 3;
    public int objectUseCost = 1;
    private void OnEnable()
    {
        SC_AxePickup.OnAxePickupCollision += OnAxePickupCollision;
    }
    private void OnDisable()
    {
        SC_AxePickup.OnAxePickupCollision -= OnAxePickupCollision;
    }

    public void AddObject(int amount)
    {
        if (objectAmount + amount >= 0)
        {
            objectAmount += amount;
        }
        else
        {
            objectAmount = 0;
        }
    }
    public int GetObjectCurrentAmount()
    {
        return objectAmount;
    }

    private void OnAxePickupCollision(int pickupAmount)
    {
        AddObject(pickupAmount);
    }

    public void Use()
    {
        if(objectAmount - objectUseCost >= 0)
        {
            AddObject(-objectUseCost);
            axeWeapon.Shoot();
        }
        
    }
}
