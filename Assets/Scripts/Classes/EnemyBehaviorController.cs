using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorController
{
    private EnemyBehavior _currentBehavior;

    public EnemyBehaviorController()
    {
        _currentBehavior = null;
    }
    public EnemyBehaviorController(EnemyBehavior behavior)
    {
        _currentBehavior = null;
        SetBehavior(behavior);
    }
    public void SetBehavior(EnemyBehavior behavior)
    {

        if(_currentBehavior != null)
        {
            _currentBehavior.Activate(false);
        }
        _currentBehavior = behavior;
        _currentBehavior.Activate();
    }
}
