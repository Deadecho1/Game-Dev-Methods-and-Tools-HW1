using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_RestartScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Scene_ExampleLevel");
    }
}
