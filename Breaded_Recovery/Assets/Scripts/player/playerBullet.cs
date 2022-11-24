using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 bulletDirection = new Vector2(1, 0);
    [SerializeField] private float bulletSpeed = 14; 

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = bulletDirection * bulletSpeed;
        if(transform.position.x >= 15) Destroy(gameObject);
    }
}
