using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private float deathTime = 3f;
    [SerializeField] private int damage = 20;
    private Vector3 dir = Vector3.zero;

    private void Start()
    {
        Destroy(gameObject, deathTime);
    }

    public void SetDirection(bool isRight)
    {
        dir = isRight ? Vector3.right : Vector3.left;
    }

    private void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent<NPCBase>(out var npc))
        {
            npc.SetDamage(damage);
        }
        Destroy(gameObject);
    }
}
