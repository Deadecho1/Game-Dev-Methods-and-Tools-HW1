using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SC_Death : MonoBehaviour
{
    public static event Action OnSpikeCollision;

    public static event Action<GameObject> OnSpikeCollisionGeneral;


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            OnSpikeCollision?.Invoke();
        }
        else
        {
            OnSpikeCollisionGeneral?.Invoke(col.gameObject);
        }
    }
}
