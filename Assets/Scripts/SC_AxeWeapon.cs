using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_AxeWeapon : MonoBehaviour, IWeapon
{
    public GameObject _axeBall;
    public static event Action OnAxeThrow;
    public void Shoot()
    {
        if (_axeBall != null)
        {
            GameObject axe = Instantiate(_axeBall, transform.position, new Quaternion());
            SC_Axe scAxe = axe.GetComponent<SC_Axe>();
            if (scAxe != null)
            {
                OnAxeThrow?.Invoke();
                float direction = 1;
                if (transform.parent != null)
                    direction = transform.parent.localScale.x;
                scAxe.Shoot(direction);
            }
        }
    }

    
}
