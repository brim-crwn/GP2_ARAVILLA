using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class SimpleInventory : MonoBehaviour
{
    private List<string> playeritems = new List<string>();
    public TextMeshProUGUI inventoryText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playeritems.Add("Excalibur");
        playeritems.Add("Potion");
    }

    

    public void RemoveItem(string itemname)
    {
        if (playeritems.Remove(itemname))
        {
            Debug.Log(itemname + " removed from inventory.");
        }
        else
        {
            Debug.LogWarning(itemname + " not found in inventory.");
        }
        UpdateUI();
    }

    //drop item from inventory when player Dies
    public void RemoveItemDrop()
    {//loops backwards to 0
        for (int i = playeritems.Count -1; i>=0; i--)
        {
            if (playeritems[i].Contains("Potion"))
            {
                Debug.Log(playeritems[i] + " removed from inventory.");
                playeritems.RemoveAt(i);

            }
        }
        UpdateUI();
    }

    public void AddItem(string itemname)
    {
        playeritems.Add(itemname);
        UpdateUI();
    }

    // Update is called once per frame
    private void UpdateUI()
    {
        inventoryText.text = "Inventory: \n";
        for (int i = 0; i < playeritems.Count; i++)
        {
            inventoryText.text += playeritems[i] + "\n";
        }
    }
}
