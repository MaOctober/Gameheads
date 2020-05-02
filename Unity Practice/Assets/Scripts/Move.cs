using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 speed; //Amount of units to move per second
    
    //Amount of degrees per second to turn
    public float turnSpeed;
    public float jumpforce = 1.0f;  
    public float distToGround = 0.5f;
    private Rigidbody rb; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {

        float currentSpeed = 0.0f;
        float currentTurnAmount = 0.0f;

        if (Input.GetKey(KeyCode.A))
        {
            currentTurnAmount -= turnSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            currentTurnAmount += turnSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed = speed.x;
        }
        if (Input.GetKey(KeyCode.S))
        {
            currentSpeed = -speed.x;
        }


        //Speed is a Vector3 defines how fast to move in 3D space
        gameObject.transform.Rotate(Vector3.up, currentTurnAmount * Time.deltaTime);
        rb.AddForce(transform.forward * currentSpeed * Time.deltaTime, ForceMode.Impulse);

        (isGrounded());
        if (Input.GetKeyDown(KeyCode.Space) 
        {
            
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
           
        }

        rb.angularVelocity = Vector3.zero;

        function isGrounded(): boolean {
              return Physics.Raycast (transform.position,-Vector3.up, distToGround + 0.1);
              rigidbody.velocity.y = jumpspeed;

    }

    
}