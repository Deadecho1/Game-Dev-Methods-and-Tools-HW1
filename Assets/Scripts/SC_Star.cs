using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Star : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            col.gameObject.GetComponent<SC_PowerUp>().CollectPowerUp(new StarInvincible());
        }
    }
}
