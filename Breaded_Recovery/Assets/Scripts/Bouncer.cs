using UnityEngine;

public class Bouncer : Enemy
{
    [SerializeField] private float speed = 5.0f;

    private Rigidbody2D rb2d;

    protected override void Awake()
    {
        base.Awake();
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Vector2 initialForce = Random.insideUnitCircle.normalized * speed;
        rb2d.AddForce(initialForce, ForceMode2D.Impulse);
    }
}
