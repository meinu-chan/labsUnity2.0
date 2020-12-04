using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFireball : MonoBehaviour
{
    private Vector3 startPosition;
    [SerializeField]private float step;
    private float proggres = 0;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate() {
        TransformPosition();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Enemy")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        if(other.CompareTag("Player")){
            Debug.Log("1");
        }
    }

    private void TransformPosition(){
        transform.position = Vector3.Lerp(startPosition,PlayerMovement.hitPosition,proggres);
        proggres += step;
    }
}
