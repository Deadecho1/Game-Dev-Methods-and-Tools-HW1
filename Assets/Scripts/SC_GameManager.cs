using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_GameManager : MonoBehaviour
{
    public static SC_GameManager GameManagerSingleton;

    private void Awake()
    {
        if(GameManagerSingleton == null)
            GameManagerSingleton = this;
    }

    public void EndLevel()
    {
        Debug.Log("Level Over");
    }

}
