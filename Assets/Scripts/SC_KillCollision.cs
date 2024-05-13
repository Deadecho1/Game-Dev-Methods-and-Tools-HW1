using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_KillCollision : MonoBehaviour
{
    public static event Action OnKillCollision;

    public static event Action<GameObject> OnKillCollisionGeneral;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            OnKillCollision?.Invoke();
        }
        else
        {
            OnKillCollisionGeneral?.Invoke(col.gameObject);
        }
    }
}
