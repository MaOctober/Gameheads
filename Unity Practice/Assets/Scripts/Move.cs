using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
 {
 	public Vector3 speed; 

 	void Start()
 	{


 	}
  
    void Update()
    {
    	Vector3 currentSpeed = Vector3.zero;

    	if (Input.GetKey(KeyCode.A))
    	{

    		currentSpeed.x = -speed.x; // current speed.x = currentSpeed.x * -1.0f 

    	}
    	if (Input.GetKey(KeyCode.D))
    	{

    		currentSpeed.x = speed.x; // current speed.x = currentSpeed.x * -1.0f 

    	}
    	if (Input.GetKey(KeyCode.W))
    	{

    		currentSpeed.z = speed.z; // current speed.x = currentSpeed.x * -1.0f 

    	}
    	if (Input.GetKey(KeyCode.S))
    	{

    		currentSpeed.z = -speed.z; // current speed.x = currentSpeed.x * -1.0f 

    	}
        //transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime, Input.GetAxis("Vertical")*Time.deltaTime, 0f);
        	gameObject.transform.Translate(currentSpeed * Time.deltaTime);
     
        }


}
    	

   
    