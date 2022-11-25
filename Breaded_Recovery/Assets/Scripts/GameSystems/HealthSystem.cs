using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamageable
{
    [SerializeField]
    private float maxHitPoints;
    

    public float HitPoints { get; private set; }
    public event Action OnHealthDepleted;

    private void Awake()
    {
        HitPoints = maxHitPoints;
      
    }

    public void TakeDamage(int damage)
    {
        HitPoints -= damage;
        Debug.Log(gameObject + " " + HitPoints.ToString());

        if (HitPoints <= 0)
        {
            OnHealthDepleted?.Invoke();
        }
    }
}
