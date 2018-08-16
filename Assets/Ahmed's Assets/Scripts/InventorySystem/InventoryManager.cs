using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public Text foodText;
    public Text waterText;
    public Text weaponText;
    public Text ArmorText;

    public int foodScore;
    public int waterScore;
    public int weaponScore;
    public int ArmorScore;

    private void Start()
    {
        foodScore = 0;
        waterScore = 0;
        weaponScore = 0;
        ArmorScore = 0;
    }

    //updates food and water inventory
    public void UpdateInventory()
    {
        foodText.text = foodScore.ToString();
        waterText.text = waterScore.ToString();
        weaponText.text = weaponScore.ToString();
        ArmorText.text = ArmorScore.ToString();
    }
}
