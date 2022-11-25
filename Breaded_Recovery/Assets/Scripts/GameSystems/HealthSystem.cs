using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamageable
{
    [SerializeField]
    private int maxHitPoints = 6;

    public int HitPoints { get; private set; }
    public event Action OnHealthDepleted;

    private void Awake()
    {
        HitPoints = maxHitPoints;
    }

    public void TakeDamage(int damage)
    {
        HitPoints -= damage;

        if (HitPoints <= 0)
        {
            OnHealthDepleted?.Invoke();
        }
    }
}
