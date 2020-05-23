using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{

    private float coin = 0;


    private void OnTriggerEnter2D(Collider2D other){
    	if(other.gameObject.CompareTag("Coin")){
    		coin ++;

    		Destroy(other.gameObject);
    	}
    }
}
