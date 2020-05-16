using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float lifeSpan = 3.0f;
	private float currentLife = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {	currentLife += Time.deltaTime;

    	if (currentLife >= lifeSpan)
    	{
        //when lifeSpan 3 seconds has past delte me
        //Hint: Time.deltaTime use to count how many seconds has past 

         Destroy(gameObject);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

    	if (collision.gameObject.CompareTag("Ground"))
    	{
    		Destroy(gameObject);
    
    	}
    }

}
