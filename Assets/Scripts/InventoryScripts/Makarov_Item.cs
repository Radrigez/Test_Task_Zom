using UnityEngine;

    [CreateAssetMenu(fileName = "Weapon" , menuName = "Inventory/Makarov_Item")]
    public class Makarov_Item : Item
    {
        public static Makarov_Item instance;
        public int damage = 5;

        public override void Use()
        {
            maxStack -= 1;
            Player.Instance.makarov.gameObject.SetActive(true);
            Player.Instance.ak_47.gameObject.SetActive(false);
            Player.Instance.Shot();
            Debug.Log("Makarov Item used");
        }
    }


