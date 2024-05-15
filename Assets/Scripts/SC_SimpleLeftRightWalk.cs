using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_SimpleLeftRightWalk : EnemyBehavior
{
    public float speed = 3f;
    public float changeDirectionTime = 2f;
    public float startDirection = 1f;
    private float direction;
    private Rigidbody2D rigid;

    public override void Activate(bool on)
    {
        base.Activate(on);
        if(on)
        {
            direction = startDirection;
            StartCoroutine(WaitThenChangeDirection());
        }
    }
    public override void BehaviorOnFixedUpdate()
    {
        if (direction != 0 && rigid != null)
        {
            rigid.velocity = new Vector2(direction * speed, rigid.velocity.y);

            if (direction > 0)
                transform.localScale = new Vector3(1, 1, 1);
            else transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    private void OnEnable()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    IEnumerator WaitThenChangeDirection()
    {
        yield return new WaitForSeconds(changeDirectionTime);
        if (IsActive)
        {
            direction *= -1;
            StartCoroutine(WaitThenChangeDirection());
        }
    }
}
