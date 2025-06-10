using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{ 
    public Transform itemsParent;
    public GameObject inventoryUI;
    
    InventorySlotUI[] slots;

    void Start()
    {
        Inventory.instance.onItemChangedCallBack += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlotUI>();
        // Назначаем индексы слотам
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].slotIndex = i;
        }
        UpdateUI();
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
            Time.timeScale = 1;
        }
        UpdateUI();
    }

   public void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < Inventory.instance.slots.Count)
            {
                slots[i].AddItem(Inventory.instance.slots[i].item, Inventory.instance.slots[i].amount);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
