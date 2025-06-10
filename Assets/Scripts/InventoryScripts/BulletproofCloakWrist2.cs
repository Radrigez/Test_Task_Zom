using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "new Item",menuName = "Inventory/BulletproofCloakWrist2")]
public class BulletproofCloakWrist2 : Item
{
    public override void Use()
    { 
        maxStack -= 1;
        Player.Instance.BulletproofCloakWrist2.gameObject.SetActive(true);
        Debug.Log("Bullet Poof Cloak Item used");
    }
}

