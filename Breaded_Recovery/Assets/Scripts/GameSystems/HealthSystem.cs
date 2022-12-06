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


    private void Awake()
    {
        if(TryGetComponent(out playerStats foundPlayerInfo))
        {
            HitPoints = playerInfo.maxHealth;
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
        if (!isPlayer) { HitPoints -= ((playerWepon.weponDamage - armor) + damage);
        }else{
            HitPoints -= damage;
        }
       

        Debug.Log(damage);
        Debug.Log(gameObject + " " + HitPoints.ToString());

        if (HitPoints <= 0)
        {
            OnHealthDepleted?.Invoke();
        }
    }
}
