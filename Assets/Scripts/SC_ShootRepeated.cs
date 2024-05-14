using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ShootRepeated : MonoBehaviour
{
    public Weapon WeaponUsed;
    public float TimeBetweenShots = 1f;

    private void OnEnable()
    {
        StartCoroutine(WaitThenShoot());
    }

    IEnumerator WaitThenShoot()
    {
        yield return new WaitForSeconds(TimeBetweenShots);
        if (gameObject.activeSelf)
        {
            WeaponUsed.Shoot();
            StartCoroutine(WaitThenShoot());
        }
    }
}
