using UnityEngine;

public class Bouncer : Enemy
{
    [SerializeField] private float speed = -5.0f;
    //[SerializeField] public float maxHealth = 10;


    private Rigidbody2D rb2d;

    protected override void Awake()
    {
        base.Awake();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        while(transform.position.x > 5.4f)
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
    }
}
