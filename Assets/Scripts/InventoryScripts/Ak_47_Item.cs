using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Weapon" , menuName = "Inventory/Ak-47")]
public class Ak_47_Item : Item
{
    public static Ak_47_Item instance;
    public Text AmmoText;
    public int damage = 10;
    public AmmoItem ammo;
    public override void Use()
    {
        maxStack -= 1;
        Player.Instance.ak_47.gameObject.SetActive(true);
        Player.Instance.makarov.gameObject.SetActive(false);
        Player.Instance.Shot();
        Debug.Log("Ak-47 Item used +++++");
    }
}
