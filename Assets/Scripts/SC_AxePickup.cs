using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AxePickup : MonoBehaviour
{
    public int PickupAmount = 1;
    static public event Action<int> OnAxePickupCollision;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            OnAxePickupCollision?.Invoke(PickupAmount);

            this.gameObject.SetActive(false);
        }
    }
}
