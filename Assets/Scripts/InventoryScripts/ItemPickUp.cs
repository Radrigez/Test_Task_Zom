using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
   public Item item;
   public int amount = 1;
   public int quentity;
   void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Player"))
      {
         bool wasPickedUp = Inventory.instance.AddItem(item, amount);
         
         if (wasPickedUp)
         {
            Destroy(gameObject);
            Debug.Log("Item Picked Up " + item.name);
         }
      }
   }
  
}
