using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resource : MonoBehaviour, IPickableObject
{
    public abstract void AddObject(int amount);

    public abstract int GetObjectCurrentAmount();

    public abstract void Use();
}
