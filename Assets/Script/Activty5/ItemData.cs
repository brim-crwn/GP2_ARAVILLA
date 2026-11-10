using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Gate Data/Item")]
public class ItemData : MonoBehaviour
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
