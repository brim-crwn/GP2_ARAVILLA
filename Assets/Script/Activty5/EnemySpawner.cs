using UnityEngine;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
public class EnemySpawner : MonoBehaviour
{
    //1.Assign Enemy Prefabs
    public EnemyData slimePrefab;
    public EnemyData goblinPrefab,banditprefab;
    public EnemyData dragonPrefab;

    // 2.Create Dictionary
    public Dictionary<int,EnemyData> levelEnemies = new Dictionary<int, EnemyData>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3. Link the level numbers (Keys) to  prefabs(Values)
        levelEnemies.Add(1, slimePrefab);
        levelEnemies.Add(2, goblinPrefab);
        levelEnemies.Add(2, banditprefab);
        levelEnemies.Add(3, dragonPrefab);

        SpawnEnemyForLevel(2, levelEnemies);
    }

    public void SpawnEnemyForLevel(int levelNumber, Dictionary<int, EnemyData> enemyLookUpTable)
    {
        //Make sure Level Actually Exists in our Dictionary
        if (enemyLookUpTable.ContainsKey(levelNumber))
        {
            EnemyData prefabsToSpawn = enemyLookUpTable[levelNumber];

            Instantiate(prefabsToSpawn);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
