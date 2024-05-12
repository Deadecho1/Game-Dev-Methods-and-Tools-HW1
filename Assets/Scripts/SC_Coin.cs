using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SC_Coin : MonoBehaviour
{
    static public event Action OnCoinCollision;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            OnCoinCollision?.Invoke();

            this.gameObject.SetActive(false);
        }
    }
}
