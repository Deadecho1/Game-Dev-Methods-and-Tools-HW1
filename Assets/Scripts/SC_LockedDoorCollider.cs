using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_LockedDoorCollider : MonoBehaviour
{
    public DoorBase door;
    public KeyBase key;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SC_KeyResource keyResource = col.gameObject.GetComponent<SC_KeyResource>();
            if (keyResource != null && key != null && door != null)
            {
                if(keyResource.GetKeyAmount(key) >= door.KeysRequired)
                {
                    keyResource.UseKey(key);
                    door.Open();
                }
            }
        }
    }
}
