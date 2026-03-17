using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircularSaw : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent<Froggy>(out var froggy))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
