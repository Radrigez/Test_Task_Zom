using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item",menuName = "Inventory/MilitaryHelmetItem")]
public class MilitaryHelmetItem : Item
{
    public override void Use()
    { 
        maxStack -= 1;
        Player.Instance.MilitaryHelmetItem.gameObject.SetActive(true);
        Debug.Log("Bullet Poof Cloak Item used");
    }
}
