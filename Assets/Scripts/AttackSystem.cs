using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Ball ball;
    [SerializeField] private float attackCDTime = 1f;
    private bool isRight;
    private float attackCD = 0;

    private void Update()
    {
        if (attackCD <= 0)
        {
            CheckAttack();
        }
        else
        {
            attackCD -= Time.deltaTime;
        }
    }

    private void CheckAttack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var b = Instantiate(ball, transform.position, Quaternion.identity);
            isRight = !spriteRenderer.flipX;
            b.SetDirection(isRight);
            attackCD = attackCDTime;
        }
    }
}
