using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamageable
{
    [SerializeField]
    private float maxHitPoints;
    

    public float HitPoints { get; private set; }
    public event Action OnHealthDepleted;
    public playerStats playerInfo;

    private void Awake()
    {
        if(TryGetComponent(out playerStats foundPlayerInfo))
        {
            HitPoints = playerInfo.maxHealth;
        }else { HitPoints = maxHitPoints; }
        Debug.Log(gameObject + " " + HitPoints.ToString());

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
