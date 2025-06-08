using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSystem : MonoBehaviour
{
    private int maxHP = 100;
    private int currentHP;
    public Slider HPBar;

    void Start()
    {
        currentHP = maxHP;
        UpdateHpBar();
    }
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP <= 0)
        {
            Die();
        }
        UpdateHpBar();
    }
    public void UpdateHpBar()
    {
        HPBar.value = currentHP;
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
}
