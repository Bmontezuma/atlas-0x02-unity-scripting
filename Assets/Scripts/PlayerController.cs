﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;  // Speed of the player

    void Start()
    {
        // Any initialization if needed
    }

    void FixedUpdate()
    {
        // Get input from the horizontal and vertical axes (arrow keys or WASD)
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a Vector3 movement based on input
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement to the player
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
