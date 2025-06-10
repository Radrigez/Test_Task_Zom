using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPSystem : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    
    public static HPSystem instance {get; private set;}
    public float maxHP = 100;
    public float currentHP;
    
    private Vector2 takeDamage;
    void Start()
    {
        currentHP = maxHP;
        UpdateHpBar();
    }
    public void TakeDamage(float damage)
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
       // HPBar.value = currentHP;
    }
    public void Die()
    {
        Destroy(this.gameObject);
    }
}
