using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxHealth;
    public int baseDamage;
    public int playerSpeed;
    public int armor;
    public int dodgeChance;

    public static string shipType;

    void Start()
    {
        maxHealth = 100;
        baseDamage = 5;
        playerSpeed = 6;
        armor = 6;
        dodgeChance = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
