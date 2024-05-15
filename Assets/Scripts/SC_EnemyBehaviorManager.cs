using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EnemyBehaviorManager : MonoBehaviour
{
    public EnemyBehavior StartingBehavior = null;
    EnemyBehaviorController _enemyController;

    private void Awake()
    {
        _enemyController = new EnemyBehaviorController();
        if(StartingBehavior != null)
            ActivateBehavior(StartingBehavior);
    }

    public void ActivateBehavior(EnemyBehavior behavior)
    {
        _enemyController.SetBehavior(behavior);
    }
}
