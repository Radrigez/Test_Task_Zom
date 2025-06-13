using UnityEngine;
[CreateAssetMenu(fileName = "Weapon" , menuName = "Inventory/weapon")]
public class Weapons : Item
{
    public int damage = 10;

    public override void Use()
    {
        base.Use();
        maxStack -= 1;
        Player.Instance.BulletPoofCloakItem.gameObject.SetActive(true);
        Debug.Log("Bullet Poof Cloak Item used");
    }
}
