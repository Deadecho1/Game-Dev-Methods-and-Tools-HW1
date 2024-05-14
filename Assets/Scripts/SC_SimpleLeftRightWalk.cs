using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SimpleLeftRightWalk : MonoBehaviour
{
    public float speed = 3f;
    public float changeDirectionTime = 2f;
    public float startDirection = 1f;
    private float direction;
    private Rigidbody2D rigid;
    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody2D>();
        direction = startDirection;
        StartCoroutine(WaitThenChangeDirection());
    }
    
    void FixedUpdate()
    {
        if (direction != 0 && rigid != null)
        {
            rigid.velocity = new Vector2(direction * speed, rigid.velocity.y);

            if (direction > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    IEnumerator WaitThenChangeDirection()
    {
        yield return new WaitForSeconds(changeDirectionTime);
        if (gameObject.activeSelf)
        {
            direction *= -1;
            StartCoroutine(WaitThenChangeDirection());
        }
    }
}
