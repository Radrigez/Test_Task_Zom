using UnityEngine;

[CreateAssetMenu(fileName = "New Item",menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName = "newItem";
    public Sprite icon = null;
    public int maxStack = 1;
    public bool isConsinable = false;

    public virtual void Use()
    {
        Debug.Log("Using" + itemName);
    }

}
/*
public class ItemPickUp2 : MonoBehaviour
{
    public Item item;
    public int amount = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.gameObject.CompareTag("Player"))
            {
                if (Inventory.instance.AddItem(item, amount))
                {
                    Destroy(gameObject);
                    Debug.Log("Item Picked Up" + item.name);                    
                }

            }
        }
    }
}
*/

