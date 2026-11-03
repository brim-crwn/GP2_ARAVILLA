using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class SimpleEnemySpawn: MonoBehaviour
{
    private List<string> activeEnemies = new List<string>();
    public TextMeshProUGUI EnemyText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }



    public void RemoveEnemy(string enemyname)
    {
        if (activeEnemies.Remove(enemyname))
        {
            Debug.Log(enemyname + " removed from active enemies.");
        }
        else
        {
            Debug.LogWarning(enemyname + " not found in active enemies.");
        }
        UpdateUI();
    }

    //Removes All active enemies from the list
    public void KillEnemies()
    {//loops backwards to 0
        for (int i = activeEnemies.Count - 1; i >= 0; i--)
        {
            activeEnemies.RemoveAt(i);
        }
        UpdateUI();
    }

    public void AddEnemy(string enemyname)
    {
        activeEnemies.Add(enemyname);
        UpdateUI();
    }

    // Update is called once per frame
    private void UpdateUI()
    {
        EnemyText.text = "Active Enemies: \n";
        for (int i = 0; i < activeEnemies.Count; i++)
        {
            EnemyText.text += activeEnemies[i] + "\n";
        }
    }
}
