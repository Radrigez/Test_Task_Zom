using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Item",menuName = "Inventory/BulletPoofCloak")]
public class BulletPoofCloakItem :Item
{
    public override void Use()
    { 
        maxStack -= 1;
        Player.Instance.BulletPoofCloakItem.gameObject.SetActive(true);
        Debug.Log("Bullet Poof Cloak Item used");
    }
}
