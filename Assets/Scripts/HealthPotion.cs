using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Healt Potion", menuName = "Inventory/Healt Potion")]
public class HealthPotion : Item
{
    public   int healAmount = 20;

    public override void Use()
    {
        base.Use();
    }
}
