using UnityEngine;
using UnityEngine.UI;

public class NPCBase : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    [SerializeField] private GameObject npcGO;
    [SerializeField] private Slider hpBar;
    private int currentHP;

    private void Start()
    {
        currentHP = hp;
        SetHPBar(1);
    }

    public void SetDamage(int dmg)
    {
        currentHP -= dmg;
        SetHPBar(Mathf.InverseLerp(0, hp, currentHP));
        if (currentHP <= 0)
        {
            Destroy(npcGO);
        }
    }

    private void SetHPBar(float param)
    {
        if (hpBar != null)
        {
            hpBar.value = param;
        }
    }
}
