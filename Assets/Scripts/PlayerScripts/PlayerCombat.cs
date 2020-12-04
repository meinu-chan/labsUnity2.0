using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject fireball;
    public static bool throwingAble = false;

    private void Start() {
        // fireball = GetComponent<GameObject>();
    }
    private void Update() {
        if(throwingAble){
            throwingAble = false;
            StartCoroutine(SimpleCoroutine());
        }
    }

    private IEnumerator SimpleCoroutine(){
        yield return new WaitForSeconds(1);
        throwFireball();
        PlayerMovement._navMeshAgent.isStopped = false;
    }
    public void throwFireball(){
        Instantiate(fireball,transform.position,Quaternion.identity);
    }

}
