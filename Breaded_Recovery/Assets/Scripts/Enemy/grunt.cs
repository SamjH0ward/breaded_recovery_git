// author sam howard

using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class grunt : Enemy
{
    [SerializeField] private float speed = -5.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField] [Range(1,1.5f)] private float rateOfFire = 1.5f;
    private float nextShotTime = 0;
    //[SerializeField] public float maxHealth = 10;


    private Rigidbody2D rb2d;

    protected override void Awake()
    {
        base.Awake();
        rb2d = GetComponent<Rigidbody2D>();
    }

   private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(speed, 0);
        
    }

    private void Update()
    {

        if (transform.position.x <= -15) Destroy(gameObject);
        if (Time.time > nextShotTime)
        {
            Instantiate(bullet, transform.position, bullet.transform.rotation);
            nextShotTime = Time.time + (1 / rateOfFire);
        }
    }
}
