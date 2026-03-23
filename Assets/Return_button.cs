using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Return_button : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button button;
    void Start()
    {
        button.onClick.AddListener(ReturnStartLvl);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(ReturnStartLvl);
        
    }

    private void ReturnStartLvl()
    {
        SceneManager.LoadScene("SampleScene");
    }
}


