using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_GameManager : MonoBehaviour
{
    private PlatformController platformController;
    public List<SC_Platform> Platforms;

    void Start()
    {
        platformController = new PlatformController();
        foreach (SC_Platform platform in Platforms)
        {
            if (platform != null)
            {
                platformController.ActivatePlatform(platform);
            }
        }
    }

}
