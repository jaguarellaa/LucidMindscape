using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 10.0f;
    public GameObject[] tualsPiece;



    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
        Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) // Check for diagonal movement
        {
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        } 

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
        if (collision.gameObject.tag == "L1")
        {
            Debug.Log("L1 collision detected!");
            tualsPiece[0].SetActive(true);
        }
    }
}
