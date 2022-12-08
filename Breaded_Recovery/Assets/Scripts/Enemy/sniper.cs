using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniper : Enemy
{
    [SerializeField] private float speed = -5.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField][Range(1, 1.5f)] private float rateOfFire = 1.5f;
    private float nextShotTime = 0;

    

    private Rigidbody2D rb2d;

    protected override void Awake()
    {
        base.Awake();
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        if (transform.position.x > 6.2) {
            rb2d.velocity = new Vector2(speed, 0);
            Debug.Log("Straight");
        }
        else
        {
            rb2d.velocity = new Vector2(0, 0);
            Debug.Log("Gay");
        }

    }

  
    void Update()
    {
        if (Time.time > nextShotTime)
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            nextShotTime = Time.time + (1 / rateOfFire);
        }
    }

   
    
}
