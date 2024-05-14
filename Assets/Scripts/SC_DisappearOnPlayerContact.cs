using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DisappearOnPlayerContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
