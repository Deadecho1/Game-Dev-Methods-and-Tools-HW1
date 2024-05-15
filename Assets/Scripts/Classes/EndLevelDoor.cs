using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelDoor : DoorBase
{
    public override void Open()
    {
        SC_GameManager.GameManagerSingleton.EndLevel();
    }
}
