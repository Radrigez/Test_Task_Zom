using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Ammo", menuName = "Inventory/Ammo")]
public class AmmoItem : Item
{
   
   public override void Use()
   {
      Player.Instance.Shot();
      maxStack -= 1;
      Debug.Log(maxStack + " ammo used");
   }
}
