using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

  
    void Update(){
        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime, Input.GetAxis("Vertical")*Time.deltaTime, 0f);
       
     
            }


}
    	

   
    