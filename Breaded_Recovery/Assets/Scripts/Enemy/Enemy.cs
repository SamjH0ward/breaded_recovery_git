// author sam howard

using System;
using UnityEngine;

[RequireComponent(typeof(HealthSystem))]
public abstract class Enemy : MonoBehaviour
{
    protected HealthSystem health;
    public static event Action OnEnemyKilled;


    protected virtual void Awake()
    {
        health = GetComponent<HealthSystem>();
    }

    private void OnEnable() => health.OnHealthDepleted += Die;
    private void OnDisable() => health.OnHealthDepleted -= Die;

    private void Die()
    {
        OnEnemyKilled?.Invoke();   
        Destroy(gameObject);
        
    }

    
}

