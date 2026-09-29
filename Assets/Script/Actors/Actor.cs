using UnityEngine;

public abstract class Actor : MonoBehaviour
{
    [Header("Basic Actor Attributes")]
    [SerializeField] private float maxhealth = 100f;
    protected float currentHealth;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float damage= 10f;


    //We mark as virtual: ensured child classes can initialize their own variable in their own Awake.
    protected virtual void Awake()
    {
        currentHealth = maxhealth;
    }

    //every enemy attacks differently, so we declare this method as abstract
    public abstract void PerformAttack();

    //We mark as virtual: so child classes can use their own implementation of TakeDamage if they want to.
    public virtual void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log($"{gameObject.name} took damage: " + damageAmount + ", Current Health: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} has died.");
        Destroy(gameObject);
    }

}
