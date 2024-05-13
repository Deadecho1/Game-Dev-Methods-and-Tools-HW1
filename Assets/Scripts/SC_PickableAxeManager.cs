using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SC_PickableAxeManager : MonoBehaviour
{
    public SC_AxeLimitedUse _axeUseRef;
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
        StartCoroutine(UpdateGUI());
    }
    private void OnAxePickup(int amount)
    {
        StartCoroutine(UpdateGUI());
    }
    private void OnAxeThrow()
    {
        StartCoroutine(UpdateGUI());
    }

    IEnumerator UpdateGUI()
    {
        yield return null; // wait 1 frame before updating for all values to set
        TextMeshProUGUI axeGui = GameObject.Find("Txt_Axes").GetComponent<TextMeshProUGUI>();
        if (axeGui != null)
        {
            axeGui.text = "Axes: " + _axeUseRef.GetObjectCurrentAmount();
        }
    }
}
