using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI winText;
    [SerializeField] private string txt;
    [SerializeField] private ButtonTest buttonTest;

    private void Start()
    {
        buttonTest.OnZeroEvent += OnZero;
    }

    private void OnDestroy()
    {
        buttonTest.OnZeroEvent -= OnZero;
    }

    private void OnZero()
    {
        winText.text = txt;
    }
}
