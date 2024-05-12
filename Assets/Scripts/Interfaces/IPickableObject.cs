using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickableObject
{
    void AddObject(int amount);
    int GetObjectCurrentAmount();
}
