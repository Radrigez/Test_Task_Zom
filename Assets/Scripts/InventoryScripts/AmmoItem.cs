using TMPro;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Ammo", menuName = "Inventory/Ammo")]
public class AmmoItem : Item
{
   public static AmmoItem instance { get; set; } 
   public override void Use()
   {
         maxStack -= 1;
         Player.Instance.Shot();
         Debug.Log(maxStack + " ammo used");  
   }
}
