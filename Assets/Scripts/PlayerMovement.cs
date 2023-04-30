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
    public Animation magic;


    public float health = 100;
    public Sprite smile, sad;



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



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "L1")
        {

            tualsPiece[0].SetActive(true);
            StartCoroutine(AnimWait());

        }
        if (collision.gameObject.tag == "L2")
        {

            tualsPiece[1].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L3")
        {

            tualsPiece[2].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L4")
        {

            tualsPiece[3].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L5")
        {

            tualsPiece[4].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L6")
        {

            tualsPiece[5].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L7")
        {

            tualsPiece[6].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L8")
        {

            tualsPiece[7].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L9")
        {

            tualsPiece[8].SetActive(true);
            StartCoroutine(AnimWait());
        }
        if (collision.gameObject.tag == "L10")
        {

            tualsPiece[9].SetActive(true);
            StartCoroutine(AnimWait());
        }
    }


    IEnumerator AnimWait()
    {

        tualsPiece[9].SetActive(true); transform.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        tualsPiece[9].SetActive(true); transform.GetComponent<Animator>().enabled = false;


    }
}
