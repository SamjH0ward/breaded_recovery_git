// author sam howard

using System;
using UnityEngine;
using Random = UnityEngine.Random;

[RequireComponent(typeof(HealthSystem))]
public abstract class Enemy : MonoBehaviour
{
    protected HealthSystem health;
    public static event Action OnEnemyKilled;
    [SerializeField] private GameObject pickUp;


    protected virtual void Awake()
    {
        health = GetComponent<HealthSystem>();
    }

    private void OnEnable() => health.OnHealthDepleted += Die;
    private void OnDisable() => health.OnHealthDepleted -= Die;

    private void Die()
    {
        OnEnemyKilled?.Invoke();
        if (Random.RandomRange(1, 100) <= 3) Instantiate(pickUp, transform.position, transform.rotation);
        Destroy(gameObject);
        
    }

    
}

