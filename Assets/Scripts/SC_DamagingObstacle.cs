using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_DamagingObstacle : MonoBehaviour
{
    public static event Action OnDamageCollision;

    public static event Action<GameObject> OnDamageCollisionGeneral;


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            OnDamageCollision?.Invoke();
        }
        else
        {
            OnDamageCollisionGeneral?.Invoke(col.gameObject);
        }
    }
}
