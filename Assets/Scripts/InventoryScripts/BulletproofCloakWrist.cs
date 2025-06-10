using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Item",menuName = "Inventory/BulletproofCloakWrist")]
public class BulletproofCloakWrist : Item
{
    public override void Use()
    { 
        maxStack -= 1;
        Player.Instance.BulletproofCloakWrist.gameObject.SetActive(true);
        Debug.Log("Bullet Poof Cloak Item used");
    }
}
