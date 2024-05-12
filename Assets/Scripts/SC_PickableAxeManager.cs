using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SC_PickableAxeManager : MonoBehaviour
{
    public SC_AxeWeapon _axeRef;
    private void OnEnable()
    {
        SC_AxePickup.OnAxePickupCollision += OnAxePickup;
        SC_AxeWeapon.OnAxeThrow += OnAxeThrow;
    }

    private void OnDisable()
    {
        SC_AxePickup.OnAxePickupCollision -= OnAxePickup;
        SC_AxeWeapon.OnAxeThrow -= OnAxeThrow;
    }
    private void Start()
    {
        UpdateGUI();
    }
    private void OnAxePickup(int amount)
    {
        UpdateGUI();
    }
    private void OnAxeThrow()
    {
        UpdateGUI();
    }

    private void UpdateGUI()
    {
        StartCoroutine(UpdateGUIWait()); // wait 1 frame for data to set, then update
    }

    IEnumerator UpdateGUIWait()
    {
        yield return null;
        TextMeshProUGUI axeGui = GameObject.Find("Txt_Axes").GetComponent<TextMeshProUGUI>();
        if (axeGui != null)
        {
            axeGui.text = "Axes: " + _axeRef.GetObjectCurrentAmount();
        }
    }
}
