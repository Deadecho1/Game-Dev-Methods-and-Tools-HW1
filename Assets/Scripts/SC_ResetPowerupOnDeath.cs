using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ResetPowerupOnDeath : MonoBehaviour
{
    private void OnEnable()
    {
        SC_HPManager.OnPlayerLoseLife += OnPlayerLoseLife;
    }

    private void OnDisable()
    {
        SC_HPManager.OnPlayerLoseLife -= OnPlayerLoseLife;
    }
    private void OnPlayerLoseLife()
    {
        gameObject.GetComponent<SC_PowerUp>()?.RemovePowerUps();
    }
}
