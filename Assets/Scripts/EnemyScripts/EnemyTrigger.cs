using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTrigger : MonoBehaviour
{
    public float speed;
    private GameObject target;
    private bool moveToPlayer = false;
    private NavMeshAgent Agent;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            target = other.gameObject;
            moveToPlayer = true;
        }
    }

    private void Start() {
        Agent = transform.GetComponent<NavMeshAgent>();
        Agent.speed = speed; 
    }
    private void OnTriggerExit(Collider other) {
        if(other.CompareTag("Player")){
            moveToPlayer=false;
            target = null;
        }
    }

    private void FixedUpdate() {
        if(moveToPlayer){
            MoveToTarget();
        }
    }

    private void MoveToTarget(){
        Agent.SetDestination(target.transform.position);
    }
}
