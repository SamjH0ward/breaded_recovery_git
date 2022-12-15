// author sam howard

using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class playerWepon : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    private ActivePowerups activePowerups_Weopn;

    [SerializeField]
    private float rateOfFire = 3f;
    public static int weponDamage = 10;
    
    private float nextShotTime = 0;
    private bool triggerHeld = false;
    // Start is called before the first frame update
    void Start()
    {
        activePowerups_Weopn = GetComponent<ActivePowerups>();
    }
    void OnShoot(InputValue input)
    {
        triggerHeld = input.Get<float>() > 0.5f;
        Debug.Log(triggerHeld);
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextShotTime && triggerHeld)
        {
            if (activePowerups_Weopn.DoubleFireActive == true)
            {
                Instantiate(projectilePrefab, new Vector3((transform.position.x + 0.3f), (transform.position.y + 0.4f)), transform.rotation);
                Instantiate(projectilePrefab, new Vector3((transform.position.x + 0.3f), (transform.position.y)), transform.rotation);
            }
            else
            {
                Instantiate(projectilePrefab, new Vector3((transform.position.x + 0.3f), (transform.position.y + 0.2f)), transform.rotation);
            }

            nextShotTime = Time.time + (1 / rateOfFire);
        }   
    }
}
