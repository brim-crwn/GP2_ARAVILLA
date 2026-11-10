using UnityEngine;


[CreateAssetMenu(fileName = "NewEnemy", menuName = "Gate Data/Enemy")]
public class EnemyData : ScriptableObject
{
    [Header("Basic Info")]
    public int enemyID;
    public string EnemyName;
    public Sprite enemyIcon;
    public GameObject enemyModel;

    [Header("CombatStats")]
    public int baseDamage;
    public int baseHealth;
    public float baseSpeed;

    [Header("Audio")]
    public AudioClip enemyNoise;

}
