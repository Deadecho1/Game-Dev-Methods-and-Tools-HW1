using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_DisappearOnEnemyContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
