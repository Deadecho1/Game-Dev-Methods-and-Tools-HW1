using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_KeyResource : MonoBehaviour
{
    private Dictionary<Type, int> keyDict;
    private void Awake()
    {
        keyDict = new Dictionary<Type, int>();
    }
    private void OnEnable()
    {
        SC_KeyPickup.OnKeyPickupCollision += OnKeyPickupCollision;
    }

    private void OnDisable()
    {
        SC_KeyPickup.OnKeyPickupCollision -= OnKeyPickupCollision;

    }
    private void OnKeyPickupCollision(KeyBase key)
    {
        if (keyDict.ContainsKey(key.GetType()))
        {
            keyDict[key.GetType()] += 1;
        }
        else
        {
            keyDict[key.GetType()] = 1;
        }
    }
    public int GetKeyAmount(KeyBase key)
    {
        if (keyDict.ContainsKey(key.GetType()))
        {
            return keyDict[key.GetType()];
        }
        else
        {
            return 0;
        }
    }

    public void UseKey(KeyBase key)
    {
        if (keyDict.ContainsKey(key.GetType()))
        {
            keyDict[key.GetType()] -= 1;
        }
    }
}
