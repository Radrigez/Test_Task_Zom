using UnityEngine;
[CreateAssetMenu(fileName = "Weapon" , menuName = "Inventory/weapon")]
public class Weapons : Item
{
    public int damage = 10;

    public override void Use()
    {
        base.Use();
        
    }
}
