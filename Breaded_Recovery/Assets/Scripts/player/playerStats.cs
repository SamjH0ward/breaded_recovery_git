// author sam howard

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

    void Awake()
    {
        switch(shipType){
            case "cruiser":
                maxHealth = 100;
                baseDamage = 7;
                playerSpeed = 5;
                armor = 8;
                dodgeChance = 3;
                break;
            case "fighter":
                maxHealth = 90;
                baseDamage = 9;
                playerSpeed = 6;
                armor = 8;
                dodgeChance = 3;
                break;
            case "racer":
                maxHealth = 80;
                baseDamage = 5;
                playerSpeed = 7;
                armor = 5;
                dodgeChance = 8;
                break;
            case "behemoth":
                maxHealth = 120;
                baseDamage = 6;
                playerSpeed = 3;
                armor = 12;
                dodgeChance = 0;
                break;
            case "destroyer":
                maxHealth = 110;
                baseDamage = 9;
                playerSpeed = 3;
                armor = 10;
                dodgeChance = 0;
                break;
            default:
                maxHealth = 100;
                baseDamage = 5;
                playerSpeed = 6;
                armor = 6;
                dodgeChance = 3;
                break;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
