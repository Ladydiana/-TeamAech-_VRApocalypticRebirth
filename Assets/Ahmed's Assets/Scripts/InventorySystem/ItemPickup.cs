using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour {

    public enum ItemType
    {
        Food,
        Water,
        Weapon,
        Armor
    };

    public ItemType itemType;
	
	public void PickUp()
    {
        InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();

        //should be added to inventory
        switch (itemType)
        {
            case ItemType.Food:
                inventoryManager.foodScore++;
                break;

            case ItemType.Water:
                inventoryManager.waterScore++;
                break;

            case ItemType.Weapon:
                inventoryManager.weaponScore++;
                break;

            case ItemType.Armor:
                inventoryManager.ArmorScore++;
                break;
        }

        inventoryManager.UpdateInventory();

        gameObject.SetActive(false);
    }
}
