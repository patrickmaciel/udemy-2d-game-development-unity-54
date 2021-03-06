﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator an;

    public float movementSpeed = 30f;
    public float jumpForce = 400f;
    public float maxVelocity = 8f;

    public AudioClip soundEffect;

    private bool Grounded;

    // Use this for initialization
    void Start()
    {
        // Get components
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Force to be applied
        var force = new Vector2(0f, 0f);

        // Get controls for horizontal movement
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Get current velocity of the Rigidbody2D
        var absVelocityX = Mathf.Abs(rb.velocity.x);
        var absVelocityY = Mathf.Abs(rb.velocity.y);

        // Check if on ground
        if (absVelocityY == 0)
        {
            Grounded = true;
        } else
        {
            Grounded = false;
        }

        // Set X force
        if (absVelocityX < maxVelocity)
        {
            force.x = (movementSpeed * moveHorizontal);
        }

        // Jump if grounded and button pressed
        if (Grounded == true && Input.GetButton("Jump"))
        {
            if (soundEffect)
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }

            Grounded = false;
            force.y = jumpForce;
            an.SetInteger("AnimState", 2);
        }

        // Apply force
        rb.AddForce(force);

        // Alter player direction
        if (moveHorizontal > 0)
        {
            // print("Right");
            transform.localScale = new Vector3(1, 1, 1);
            if (Grounded)
            {
                an.SetInteger("AnimState", 1);
            }
        } else if (moveHorizontal < 0)
        {
            // print("Left");
            transform.localScale = new Vector3(-1, 1, 1);
            if (Grounded)
            {
                an.SetInteger("AnimState", 1);
            }
        } else
        {
            // print("Still");
            if (Grounded)
            {
                an.SetInteger("AnimState", 0); 
            }
        }
    }
}
