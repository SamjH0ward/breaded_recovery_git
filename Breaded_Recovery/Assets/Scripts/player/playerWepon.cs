using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Random = UnityEngine.Random;

public class playerWepon : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private float rateOfFire = 3.0f;

    private float nextShotTime = 0;
    private bool triggerHeld = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnShoot(InputValue input)
    {
        triggerHeld = input.Get<float>() > 0.5f;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextShotTime && triggerHeld)
        {
            var bullet = Instantiate(projectilePrefab,new Vector3(transform.position.x, transform.position.y + 0.2f), transform.rotation);
        
            nextShotTime = Time.time + (1 / rateOfFire);
        }   
    }
}
