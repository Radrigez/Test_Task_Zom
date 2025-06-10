using UnityEngine;
using UnityEngine.UI;

public class AmmoLogic : ItemPickUp
{
    public static AmmoLogic instanse;
    public Text ammoText;
    private int _ammoCount;

    void Start()
    {
       // ammoText.text = amount.ToString();
       // amount = _ammoCount;
       // amount.ToString();
    }
}
