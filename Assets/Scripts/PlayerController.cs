using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    public int speed = 5;
    public int jumpHeight = 6;

    private bool canJump = true;

    private Vector2 left;

    private Vector2 right;

    private HealthScript hs;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hs = GetComponent<HealthScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        if (horizontal > 0)
        {
            right = Vector2.right * horizontal * speed;
            left = Vector2.zero;
        }

        if (horizontal<0)
        {
            left = Vector2.left * horizontal * -1 * speed;
            right = Vector2.zero;
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity = new Vector2(0,jumpHeight);
        }

    }

    private void FixedUpdate()
    {
        Vector2 movement = left + right;
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Platform"))
        {
            canJump = true;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Platform"))
        {
            canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.gameObject.CompareTag("Platform"))
        {
            canJump = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.gameObject.CompareTag("Whiskey"))
        {
            hs.Die();
        }

        if (other.transform.gameObject.CompareTag("IDcardTrigger"))
        {
            PlayerShootingL3Script ss = transform.gameObject.GetComponent<PlayerShootingL3Script>();
            ss.EnableShooting();
        }
    }


}
