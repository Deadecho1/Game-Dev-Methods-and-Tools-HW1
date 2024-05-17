using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SC_UIMessageManager : MonoBehaviour
{
    static public SC_UIMessageManager instance;
    private TextMeshProUGUI MessageRef;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            MessageRef = GameObject.Find("Txt_GameMessage").GetComponent<TextMeshProUGUI>();
            MessageRef.gameObject.SetActive(false);
        }
    }

    public void DisplayMessage(string message)
    {
        MessageRef.gameObject.SetActive(true);
        MessageRef.text = message;
    }

    public void RemoveMessage()
    {
        MessageRef.gameObject.SetActive(false);
    }

}
