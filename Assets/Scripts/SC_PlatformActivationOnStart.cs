using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlatformActivationOnStart : MonoBehaviour
{
    public SC_GameManager GameManagerRef;
    private void Awake()
    {
        SC_Platform plat = GetComponent<SC_Platform>();
        if (plat != null && GameManagerRef != null)
            GameManagerRef.Platforms.Add(plat);
        else
        {
            Debug.Log("GameManagerRef not set on platform for start activation");
        }
    }
}

