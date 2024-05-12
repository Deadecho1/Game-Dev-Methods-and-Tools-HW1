using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AxeWeapon : PickableUsableObject, IWeapon
{
    public GameObject _axeBall;
    public static event Action OnAxeThrow;

    private void OnEnable()
    {
        SC_AxePickup.OnAxePickupCollision += OnAxePickupCollision;
    }
    private void OnDisable()
    {
        SC_AxePickup.OnAxePickupCollision -= OnAxePickupCollision;
    }


    public void Shoot()
    {
        if (objectAmount > 0 && objectUseCost <= objectAmount && _axeBall != null)
        {
            GameObject axe = Instantiate(_axeBall, transform.position, new Quaternion());
            SC_Axe scAxe = axe.GetComponent<SC_Axe>();
            if (scAxe != null)
            {
                AddObject(-objectUseCost);
                OnAxeThrow?.Invoke();
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scAxe.Shoot(direction);
            }
        }
    }

    public override void AddObject(int amount)
    {
        if(objectAmount + amount >= 0)
        {
            objectAmount += amount;
        }
        else
        {
            objectAmount = 0;
        }
    }

    public override int GetObjectCurrentAmount()
    {
        return objectAmount;
    }

    private void OnAxePickupCollision(int pickupAmount)
    {
        AddObject(pickupAmount);
    }
}
