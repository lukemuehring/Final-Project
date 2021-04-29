using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFall2 : MonoBehaviour
{

    public float timeToDeactivate = 1.0f;
    private GameObject sphereTrigger1;

    void Awake(){
        sphereTrigger1 = this.transform.parent.GetChild(2).gameObject;
    }

    void OnTriggerEnter(Collider other){
        if(PlayerCasting.hasPressedButton && other.gameObject.CompareTag("Player")){
            this.gameObject.GetComponent<BoxCollider>().enabled = false; //can't trigger fall again
            sphereTrigger1.SetActive(true);
            StartCoroutine(DeactivateSpheres());
        }
    }

    IEnumerator DeactivateSpheres(){
        yield return new WaitForSeconds(timeToDeactivate);
        sphereTrigger1.SetActive(false);
    }
}
