// author sam howard

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 bulletDirection = new Vector2(-1, 0);
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private int damage = 15;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = bulletDirection * bulletSpeed;
        if(transform.position.x <= -15) Destroy(gameObject);
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();

        if (damageable != null)
        {
            damageable.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
   
}
