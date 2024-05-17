using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SC_GameManager : MonoBehaviour
{
    public static SC_GameManager GameManagerSingleton;
    public Canvas RestartCanvas;

    private void Awake()
    {
        if(GameManagerSingleton == null)
            GameManagerSingleton = this;
    }
    private void Start()
    {
        RestartCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    private void OnEnable()
    {
        SC_HPManager.OnGameOver += OnGameOver;
    }
    private void OnDisable()
    {
        SC_HPManager.OnGameOver -= OnGameOver;
    }
    private void OnGameOver()
    {
        EndLevel("Game Over");
    }

    public void EndLevel(string message)
    {
        Time.timeScale = 0;
        RestartCanvas.gameObject.SetActive(true);
        TextMeshProUGUI txt = GameObject.Find("Txt_Message").GetComponent<TextMeshProUGUI>();
        if(txt != null)
        {
            txt.text = message;
        }
    }

}
