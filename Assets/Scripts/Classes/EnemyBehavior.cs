using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    protected bool IsActive;
    public void Activate()
    {
        Activate(true);
    }
    public virtual void Activate(bool on)
    {
        IsActive = on;
    }
    // Behavior will be called with Unity's FixedUpdate
    public virtual void BehaviorOnFixedUpdate() {
    }
    private void FixedUpdate()
    {
        if(IsActive)
            BehaviorOnFixedUpdate();       
    }
}