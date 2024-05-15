using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DoorBase : MonoBehaviour
{
    public int KeysRequired = 1;
    public abstract void Open();
}
