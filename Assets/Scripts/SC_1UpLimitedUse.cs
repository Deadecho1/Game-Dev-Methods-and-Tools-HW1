using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_1UpLimitedUse : Resource
{
    public int objectAmount = 3;
    public int objectUseCost = 1;
    
    public override void AddObject(int amount)
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

    public override int GetObjectCurrentAmount()
    {
        return objectAmount;
    }

    public override void Use()
    {
        AddObject(-objectUseCost);
    }
}
