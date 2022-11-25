using UnityEngine;

[RequireComponent(typeof(HealthSystem))]
public abstract class Enemy : MonoBehaviour
{
    protected HealthSystem health;

    protected virtual void Awake()
    {
        health = GetComponent<HealthSystem>();
    }

    private void OnEnable() => health.OnHealthDepleted += Die;
    private void OnDisable() => health.OnHealthDepleted -= Die;

    private void Die()
    {
        Destroy(gameObject);
    }
}

