using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControler : MonoBehaviour
{
    [SerializeField]float moveSpeed = 6.5f;

    private Rigidbody2D rb2d;
    private Vector2 plaeyrInput;

    // Start is called before the first frame update
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
}
