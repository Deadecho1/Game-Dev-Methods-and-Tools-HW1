using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_KeyPickup : MonoBehaviour
{
    public KeyBase Key;
    static public event Action<KeyBase> OnKeyPickupCollision;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            OnKeyPickupCollision?.Invoke(Key);

            this.gameObject.SetActive(false);
        }
    }
}
