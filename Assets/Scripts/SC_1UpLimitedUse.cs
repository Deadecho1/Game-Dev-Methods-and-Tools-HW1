using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_1UpLimitedUse : MonoBehaviour, IPickableUsableObject
{
    public int objectAmount = 3;
    public int objectUseCost = 1;
    
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

    public void Use()
    {
        AddObject(-objectUseCost);
    }
}
