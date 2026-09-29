using UnityEngine;

public class Grunt : Actor
{
    protected override void Awake()
    {
        base.Awake();
        maxhealth = 50f; // Set Grunt's max health
        currentHealth = maxhealth; // Initialize current health
        speed = 4; // Set Grunt's speed


    }
    public override void PerformAttack()
    {
        Debug.Log($"{gameObject.name} bashed player did {damage} damage");
    }
}
