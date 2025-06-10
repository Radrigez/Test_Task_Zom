using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
   public static Inventory instance;
   
   public List<InventorySlot> slots = new List<InventorySlot>();
   public int maxSlots = 24;
   
   public delegate void OnItemChanged();
   public OnItemChanged onItemChangedCallBack;

   public Button shootButton;
   
   void Awake()
   {
      if (instance != null)
      {
         Debug.LogWarning("More than one instance of Inventory script found!");
         return;
      }
      instance = this;
      // Инициализация слотов
      for (int i = 0; i < maxSlots; i++)
      {
         slots.Add(new InventorySlot());
      }
   }

   public bool AddItem(Item item, int amount)
   {
      // Попытка сложить в существующий стек
      if (item.maxStack > 1)
      {
         foreach (InventorySlot slot in slots)
         {
            if (slot.item == item && slot.amount < item.maxStack)
            {
               slot.amount += amount;
               onItemChangedCallBack?.Invoke();
               return true;
            }
         }
      } 
      // Поиск пустого слота
      foreach (InventorySlot slot in slots)
      {
         if (slot.item == null)
         {
            slot.item = item;
            slot.amount = amount;
            onItemChangedCallBack?.Invoke();
            return true;
         }
      }
      Debug.Log("Not enough room in inventory!");
      return false;
   }
   public void RemoveItem(int slotIndex)
   {
      slots[slotIndex].item = null;
      slots[slotIndex].amount = 0;
      onItemChangedCallBack?.Invoke();
   }
   public void UseItem(int slotIndex)
   {
      if (slots[slotIndex].item != null)
      {
         slots[slotIndex].item.Use();
         if (slots[slotIndex].item.isConsinable)
         {
            slots[slotIndex].amount--;
            if (slots[slotIndex].amount <= 0)
            {
               RemoveItem(slotIndex);
            }
         }
      }
   }
   
}
