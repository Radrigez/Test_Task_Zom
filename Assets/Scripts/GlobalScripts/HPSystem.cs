using UnityEngine;

public class HPSystem : MonoBehaviour
{
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
