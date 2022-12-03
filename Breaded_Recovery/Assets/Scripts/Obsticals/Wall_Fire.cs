// aurtour tom

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Fire : MonoBehaviour
{
    private Rigidbody2D rigid;
    private BoxCollider2D Collision;
    [SerializeField] private float speed = 4;
    [SerializeField] private int dmg = 10;
    // Start is called before the first frame update
    void Start()
    {
       rigid = GetComponent<Rigidbody2D>();
        Collision = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = -transform.right * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable damageable = other.GetComponent<IDamageable>();

        if (damageable != null)
        {
            damageable.TakeDamage(dmg);
        }
        Destroy(Collision);
    }
}
