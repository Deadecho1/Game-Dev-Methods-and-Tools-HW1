using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AxeWeapon : MonoBehaviour, IPickableObject, IWeapon
{
    public GameObject _axeBall;
    public int objectAmount = 0;

    public void Shoot()
    {
        if (objectAmount > 0 && _axeBall != null)
        {
            GameObject axe = Instantiate(_axeBall, transform.position, new Quaternion());
            SC_Axe scAxe = axe.GetComponent<SC_Axe>();
            if (scAxe != null)
            {
                objectAmount -= 1;
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scAxe.Shoot(direction);
            }
        }
    }

    public void AddObject(int amount)
    {
        if(amount >= 0)
        {
            objectAmount += amount;
        }
    }

    public int GetObjectCurrentAmount()
    {
        return objectAmount;
    }
}
