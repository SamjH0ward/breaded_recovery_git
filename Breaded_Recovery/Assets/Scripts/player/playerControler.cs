using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(HealthSystem))]
public class playerControler : MonoBehaviour
{
    [SerializeField]float moveSpeed = 6.5f;
    protected HealthSystem health;

    private Rigidbody2D rb2d;
    private Vector2 plaeyrInput;

    // Start is called before the first frame update

    protected virtual void Awake()
    {
        health = GetComponent<HealthSystem>();
    }
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue input)
    {
        plaeyrInput = input.Get<Vector2>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.velocity = plaeyrInput * moveSpeed;
       
    }

    private void OnEnable() => health.OnHealthDepleted += Die;
    private void OnDisable() => health.OnHealthDepleted -= Die;

    private void Die()
    {
        Destroy(gameObject);
    }
}
