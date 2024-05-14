using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlower : IPowerUp
{
    public void ApplyPowerUp(GameObject player)
    {
        Debug.Log("ApplyPowerUp Fire Flower");
        if(player != null)
        {
            SC_FireballweaponEquippable scFireballWeapon = player.GetComponentInChildren<SC_FireballweaponEquippable>();
            if (scFireballWeapon != null)
                scFireballWeapon.Equip();
        }
    }

    public void RemovePowerUp(GameObject player)
    {
        Debug.Log("RemovePowerUp Fire Flower");
        if (player != null)
        {
            SC_FireballweaponEquippable scFireballWeapon = player.GetComponentInChildren<SC_FireballweaponEquippable>();
            if (scFireballWeapon != null)
                scFireballWeapon.UnEquip();
        }
    }
    public bool IsStackable()
    {
        return false;
    }
}
