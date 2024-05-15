using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlatformManager : MonoBehaviour
{
    public static SC_PlatformManager PlatformManagerSingleton;

    private PlatformController _platformController;

    private void Awake()
    {
        if(PlatformManagerSingleton == null)
        {
            _platformController = new PlatformController();
            PlatformManagerSingleton = this;
        }
    }
    public void ActivatePlatform(SC_Platform platform)
    {
        _platformController.ActivatePlatform(platform);
    }

}
