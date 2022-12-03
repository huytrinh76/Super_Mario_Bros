using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 8f;
    private Rigidbody2D _rigidbody;
    private float inputAxis;
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
    }

    private void FixedUpdate()
    {
        Vector2 position = _rigidbody.position;
        position += velocity * Time.fixedDeltaTime;
        _rigidbody.MovePosition(position);
    }

    void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
    }
}
