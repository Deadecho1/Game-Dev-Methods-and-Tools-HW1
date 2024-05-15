using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlatformActivationOnStart : MonoBehaviour
{
    private void Start()
    {
        SC_Platform plat = GetComponent<SC_Platform>();
        if(plat != null)
        {
            SC_PlatformManager.PlatformManagerSingleton.ActivatePlatform(plat);
        }    
    }
}

