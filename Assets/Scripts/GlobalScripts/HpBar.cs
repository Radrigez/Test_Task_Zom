using UnityEngine;
public class HpBar : MonoBehaviour
{
    public float maxHealth = 100; 
    public Transform hpBarTransform;
    private float currentHealth; 
    private Vector3 initialScale;
    void Start() 
    {
        currentHealth = maxHealth; 
        initialScale = hpBarTransform.localScale;
    }
    public void TakeDamage(float damage) 
    { 
        currentHealth = Mathf.Max(0, currentHealth - damage); 
        UpdateHealthBar();
    }
    void UpdateHealthBar() 
    { 
        float percent = currentHealth / maxHealth; 
        hpBarTransform.localScale = new Vector3(initialScale.x * percent, initialScale.y, initialScale.z);
    }
    
}


