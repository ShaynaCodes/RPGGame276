using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    public float playerPosition;
   
    float mx;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);


        rb.velocity = movement;
      //  Debug.Log("your x is " + transform.position.x);
      //  Debug.Log("your y is " + transform.position.y);
        playerPosition = transform.position.x;
        
    }

}
