using UnityEngine;

public class Runner : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxhealth = 10f; // Set Runner's max health
        currentHealth = maxhealth; // Initialize current health
        speed = 10; // Set Runner's speed
        damage = 40; // Set Runner's damage


    }
    public override void PerformAttack()
    {
        Debug.Log($"{gameObject.name} Tackle player did {damage} damage");
    }
}