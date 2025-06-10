using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlotUI : MonoBehaviour, IPointerClickHandler
{
    public static InventorySlotUI instance;
    public Image icon = null;
    public Text amountText = null;
    public int slotIndex;
    public GameObject deleteButton;
    public GameObject UseButton;

    
    public void AddItem(Item newItem, int amount)
    {
        if (newItem != null || amount != 0)
        {
            icon.sprite = newItem.icon;
            icon.enabled = true;
        
            if (amount > 1)
            {
                amountText.text = amount.ToString();
            }
            else
            {
                amountText.text = " ";
            }    
        }
        else
        {
            icon.sprite = null;
            icon.enabled = false;
        }
        
    }

    public void ClearSlot()
    {
        icon.sprite = null;
        icon.enabled = false;
        amountText.text = "";
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Inventory.instance.UseItem(slotIndex);
        }
        
        else if (eventData.button == PointerEventData.InputButton.Left)
        {
            deleteButton.SetActive(!deleteButton.activeSelf);
            //UseButton.SetActive(!UseButton.activeSelf);
        }
    }
    
    public void OnDeleteButton()
    {
        Inventory.instance.RemoveItem(slotIndex);
        deleteButton.SetActive(false);
        icon.sprite = null;
        icon.enabled = false;
        amountText.text = " ";
    }
    public void OnUseButton()
    {
        Inventory.instance.RemoveItem(slotIndex);
        UseButton.SetActive(false);
        icon.sprite = null;
        icon.enabled = false;
        amountText.text = " ";
        amountText.text = Player.Instance.armorText.ToString();
    }

   /*
 
    public void SetInventor()
    {
        InventoryDate date = new InventoryDate();
        for (int i = 0; i < slots.Count; i++)
        {
            if (slots[i].item != null)
            {
                date.itemNames.Add(slots[i].item.name);
                date.amounts.Add(slots[i].amount);

            }
        }
        string json = JsonUtility.ToJson(date);
        PlayerPrefs.SetString("InventoryDate", json);
        
    }

    public void LoadInventory()
    {
        if (PlayerPrefs.HasKey("InventoryDate"))
        {
            string json = PlayerPrefs.GetString("InventoryDate");
            InventoryDate date = JsonUtility.FromJson<InventoryDate>(json);

            for (int i = 0; i < date.itemNames.Count; i++)
            {
                Item item = Resources.Load<Item>("Items/" + date.itemNames[i]);
                if (item != null)
                {
                    slots[i].item = item;
                    slots[i].amount = date.amounts;
                }
            }
        }
    }
    */
}
