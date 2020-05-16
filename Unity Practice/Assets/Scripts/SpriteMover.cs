using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody2D rb;
    private float distanceToGround = 0.0f;
    private int jumpCount = 0;
    public float jumpForce = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        distanceToGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float currentSpeed = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentSpeed -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentSpeed += speed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && IsGrounded())
        {

        rb.AddForce(new Vector2(currentSpeed * Time.deltaTime, 0.0f), ForceMode2D.Impulse);
        }
         bool IsGrounded()
        {
        return Physics.Raycast(transform.position, Vector2.down, distanceToGround + 0.1f);
//        
         }
       
        bool isGrounded = IsGrounded();

        if (isGrounded)
        {
            jumpCount = 0;

     }
}
    
