using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnObject;             
    private Vector3 sP;  
    public float spawnTime = 1f;
    
    private int iter = 0;

    
    void Start ()
    {   
        sP = spawnPoint.GetComponent<Collider>().bounds.size/2 - new Vector3(2,0,2);
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }
    
    
    void Spawn ()
    {    
        float spawnPointX = Random.Range (-sP.x , sP.x);
        float spawnPointZ = Random.Range (-sP.z , sP.z);
        Vector3 spawnPosition = new Vector3 (spawnPointX, spawnObject.GetComponent<Collider>().bounds.size.y/2, spawnPointZ);
        
        if(iter < 10){
            Instantiate(spawnObject, spawnPosition, Quaternion.identity);
            iter++;
        }       
    }
}
