using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp
{
    void ApplyPowerUp(GameObject player);
    void RemovePowerUp(GameObject player);
    bool IsStackable();
}
