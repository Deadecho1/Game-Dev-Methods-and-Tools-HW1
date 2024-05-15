using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKey : KeyBase
{
    public override bool OpenDoor(DoorBase door)
    {
        TestDoor d = door as TestDoor;
        if (d != null)
        {
            d.Open();
            return true;
        }
        return false;
    }
}
