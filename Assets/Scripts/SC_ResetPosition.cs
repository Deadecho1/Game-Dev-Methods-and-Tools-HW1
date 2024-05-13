using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ResetPosition : MonoBehaviour
{
    private Vector3 startPositon;
    private void OnEnable()
    {
        SC_HPManager.OnPlayerLoseLife += ResetPosition;
    }
    private void OnDisable()
    {
        SC_HPManager.OnPlayerLoseLife -= ResetPosition;
    }
    void Awake()
    {
        startPositon = transform.position;
    }
    private void ResetPosition()
    {
        transform.position = startPositon;
    }
}
