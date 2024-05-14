using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_FireballweaponEquippable : SC_FireballWeapon, IEquipable
{
    private bool _isEquip = false;

    public override void Shoot()
    {
        if (_isEquip)
            base.Shoot();
    }
    public void Equip()
    {
        _isEquip = true;
    }

    public void UnEquip()
    {
        _isEquip = false;
    }
}
