using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ShootRepeated : EnemyBehavior
{
    public Weapon WeaponUsed;
    public float TimeBetweenShots = 1f;

    public override void Activate(bool on)
    {
        base.Activate(on);
        StartCoroutine(WaitThenShoot());
    }

    IEnumerator WaitThenShoot()
    {
        yield return new WaitForSeconds(TimeBetweenShots);
        if (IsActive)
        {
            WeaponUsed.Shoot();
            StartCoroutine(WaitThenShoot());
        }
    }
}
