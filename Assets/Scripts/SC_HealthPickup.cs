using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_HealthPickup : MonoBehaviour
{
    public int PickupAmount = 1;
    static public event Action<int> OnHealthPickupCollision;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            OnHealthPickupCollision?.Invoke(PickupAmount);

            this.gameObject.SetActive(false);
        }
    }
}
