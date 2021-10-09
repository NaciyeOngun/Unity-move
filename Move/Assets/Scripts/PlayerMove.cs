using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //unity playermove script te speed değerini vermeyi unutmayın.

    private Rigidbody2D rigidbody;
    public float speed;
    private float moveInput;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

     void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rigidbody.velocity = new Vector2(moveInput * speed, rigidbody.velocity.y);
    }
}
