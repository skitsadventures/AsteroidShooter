using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public float moveSpeed = 12f;
    public Rigidbody2D rb;

    Vector2 movement;
   
    void Update()
    {
        movement.y = Input.GetAxisRaw("Vertical"); 
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
