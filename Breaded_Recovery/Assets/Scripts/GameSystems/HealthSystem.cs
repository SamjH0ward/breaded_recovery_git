// author sam howard

using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour, IDamageable
{
    [SerializeField]
    private float maxHitPoints;
    [SerializeField]
    [Tooltip("Set the armor for the enemy")]
    private int setArmor = 1;

    public float HitPoints { get; private set; }
    public float armor { get; private set; }
    public event Action OnHealthDepleted;
    public playerStats playerInfo;
    private bool isPlayer;
    public event Action OnHealthChanged;

    private void Awake()
    {
        if(TryGetComponent(out playerStats foundPlayerInfo))
        {
            HitPoints = playerInfo.maxHealth;
            Debug.Log(armor);
            armor = playerInfo.armor;
            isPlayer = true;
        }else { 
            HitPoints = maxHitPoints;
            armor = setArmor;
        }
        Debug.Log(gameObject + " " + HitPoints.ToString());

    }

    public void TakeDamage(int damage)
    {
        if (!isPlayer) {
            HitPoints -= ((playerWepon.weponDamage - armor) + damage);
            
        }else{
            float damageTaken = damage - armor;
            if(damageTaken > 0) HitPoints -= damage - armor;
            OnHealthChanged?.Invoke();
        }
    

        if (HitPoints <= 0)
        {
            OnHealthDepleted?.Invoke();
        }
    }
}
