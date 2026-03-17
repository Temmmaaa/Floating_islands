using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCThrowable : NPCBase
{
    [SerializeField] private EnemyBall ball;
    [SerializeField] private float attackCDTime = 3f;
    [SerializeField] private bool isRight;
    private float attackCD = 0;

    private void Update()
    {
        if (attackCD <= 0)
        {
            Attack();
        }
        else
        {
            attackCD -= Time.deltaTime;
        }
    }

    private void Attack()
    {
        var b = Instantiate(ball, transform.position, Quaternion.identity);
        b.SetDirection(isRight);
        attackCD = attackCDTime;
    }
}
