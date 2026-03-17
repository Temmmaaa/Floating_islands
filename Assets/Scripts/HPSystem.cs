using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private int hp = 100;
    private int currentHP;

    private void Start()
    {
        currentHP = hp;
        hpText.text = currentHP.ToString();
    }

    public void SetDamage(int dmg)
    {
        currentHP -= dmg;
        hpText.text = currentHP.ToString();
        if (currentHP <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
