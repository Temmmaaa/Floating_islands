using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMovable : NPCBase
{
    [SerializeField] private Transform botCheckTransform;
    [SerializeField] private float botCheckRadius;
    [SerializeField] private Transform frontCheckTransform;
    [SerializeField] private float frontCheckRadius;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private bool hasFront;
    private bool hasBot;
    private bool isLeft;

    private void Update()
    {
        CheckBot();
        CheckFront();
        Movement();
    }

    private void CheckBot()
    {
        hasBot = Physics2D.OverlapCircle(botCheckTransform.position,
            botCheckRadius);
    }

    private void CheckFront()
    {
        hasFront = Physics2D.OverlapCircle(frontCheckTransform.position,
            frontCheckRadius);
    }

    private void Movement()
    {
        if(hasBot && !hasFront)
        {
            float mod = isLeft ? -1 : 1;
            rb.linearVelocity = new Vector2(mod * speed, rb.linearVelocity.y);
        }
        else
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
            isLeft = !isLeft;
        }
    }

    private void OnDrawGizmos()
    {
        if (botCheckTransform != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(botCheckTransform.position, botCheckRadius);
        }

        if (frontCheckTransform != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(frontCheckTransform.position, frontCheckRadius);
        }
    }
}
