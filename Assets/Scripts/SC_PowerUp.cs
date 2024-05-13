using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PowerUp : MonoBehaviour
{
    IPowerUp currPowerUp;
    IPowerUp currStackablePowerUp;
    public void CollectPowerUp(IPowerUp powerUp)
    {
        if (powerUp.IsStackable())
        {
            currStackablePowerUp?.RemovePowerUp(this.gameObject);
            currStackablePowerUp = powerUp;
        }
        else
        {
           currPowerUp?.RemovePowerUp(this.gameObject);
           currPowerUp = powerUp;
        }
        powerUp.ApplyPowerUp(this.gameObject);
    }
    public void RemovePowerUps()
    {
        currStackablePowerUp?.RemovePowerUp(this.gameObject);
        currPowerUp?.RemovePowerUp(this.gameObject);
        currPowerUp = null;
        currStackablePowerUp = null;


    }
}
