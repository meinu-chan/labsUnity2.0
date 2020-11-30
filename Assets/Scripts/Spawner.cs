using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject enemy;             
    private Vector3 sP;  
    public float spawnTime = 1f;

    
    void Start ()
    {   
        sP = spawnPoint.GetComponent<Collider>().bounds.size/2 - new Vector3(2,0,2);
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }
    
    
    void Spawn ()
    {    
        float spawnPointX = Random.Range (-sP.x , sP.x);
        float spawnPointZ = Random.Range (-sP.z , sP.z);
        Vector3 spawnPosition = new Vector3 (spawnPointX, enemy.GetComponent<Collider>().bounds.size.y/2, spawnPointZ);
        
        Instantiate(enemy, spawnPosition, Quaternion.identity);
    }
}
