using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallingBox : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Froggy>(out var froggy))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
