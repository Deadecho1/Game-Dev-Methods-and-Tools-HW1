using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SC_HPGUIManager : MonoBehaviour
{
    public SC_1UpLimitedUse _marioHpRef;
    private void OnEnable()
    {
        SC_HPManager.OnPlayerLoseLife += OnPlayerLoseLife;
        SC_HPManager.OnPlayerGainLife += OnPlayerGainLife;
    }

    private void OnDisable()
    {
        SC_HPManager.OnPlayerLoseLife -= OnPlayerLoseLife;
        SC_HPManager.OnPlayerGainLife -= OnPlayerGainLife;
    }
    private void Start()
    {
        StartCoroutine(UpdateGUI());
    }
    private void OnPlayerLoseLife()
    {
        StartCoroutine(UpdateGUI());
    }
    private void OnPlayerGainLife()
    {
        StartCoroutine(UpdateGUI());
    }
    IEnumerator UpdateGUI()
    {
        yield return null; // wait 1 frame before updating for all values to set
        TextMeshProUGUI axeGui = GameObject.Find("Txt_HP").GetComponent<TextMeshProUGUI>();
        if (axeGui != null)
        {
            axeGui.text = "Life: " + _marioHpRef.GetObjectCurrentAmount();
        }
    }
}
