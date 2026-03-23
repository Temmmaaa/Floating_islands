using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_script : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Button button;
    [SerializeField] private Button button_2;
    [SerializeField] private Button button_3;
    void Start()
    {
        button.onClick.AddListener(StartLvl1);
        button_2.onClick.AddListener(StartLvl2);
        button_3.onClick.AddListener(StartLvl3);

    }

    // Update is called once per frame
    private void OnDestroy()
    {
        button.onClick.RemoveListener(StartLvl1);
        button_2.onClick.RemoveListener(StartLvl2);
        button_3.onClick.RemoveListener(StartLvl3);
    }

    private void StartLvl1()
    {
        SceneManager.LoadScene("Level1 1");
    }

    private void StartLvl2()
    {
        SceneManager.LoadScene("Level1 2");
    }

    private void StartLvl3()
    {
        SceneManager.LoadScene("Level1 3");
    }


}
