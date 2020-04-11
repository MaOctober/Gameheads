using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	public Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//Vecotr3(x,y,z)= Vector3(0.1,0,0) give me a vector that is 0.01 units in size 
      gameObject.transform.Translate(speed); 
    }
}
