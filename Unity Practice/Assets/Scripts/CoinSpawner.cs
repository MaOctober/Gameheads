using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    public Mesh gizmoMesh;

    private GameObject coinObject;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();    
    }

    public void Spawn()
    {
        if (coinObject == null)
        {
            coinObject = GameObject.Instantiate(CoinPrefab, transform.position, Quaternion.identity);
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawMesh(gizmoMesh, transform.position, Quaternion.Euler(90.0f, 0.0f, 0.0f)); 
    }
}