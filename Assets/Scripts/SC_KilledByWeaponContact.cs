using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_KilledByWeaponContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("FriendlyWeapon"))
        {
            gameObject.SetActive(false);
        }
    }
}
