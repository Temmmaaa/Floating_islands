using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public event Action OnZeroEvent;
    [SerializeField] private Button button;
    [SerializeField] private int count = 100;
    [SerializeField] private TextMeshProUGUI countText;

    private void Start()
    {
        button.onClick.AddListener(Click);
        countText.text = count.ToString();
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(Click);
    }

    private void Click()
    {
        if (count > 0 ) 
        {
            count--;
            countText.text = count.ToString();
            if(count == 0)
            {
                OnZeroEvent?.Invoke();
            }
        }
    }
}
