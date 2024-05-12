using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickableUsableObject : MonoBehaviour, IPickableObject
{
    public int objectAmount;
    public int objectUseCost = 1;
    abstract public void AddObject(int amount);
    abstract public int GetObjectCurrentAmount();

}
