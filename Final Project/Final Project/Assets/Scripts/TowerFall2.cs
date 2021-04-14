using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFall2 : MonoBehaviour
{
    //public GameObject serverTower1; //not needed right now, might use later
    public GameObject sphereTrigger1;
    //public GameObject serverTower2;
    public GameObject sphereTrigger2;
    public float timeToDeactivate = 1.0f;


    void OnTriggerEnter(Collider other){
        this.gameObject.GetComponent<BoxCollider>().enabled = false; //can't trigger fall again
        sphereTrigger1.SetActive(true);
        sphereTrigger2.SetActive(true);

        StartCoroutine(DeactivateSpheres());
    }

    IEnumerator DeactivateSpheres(){
        yield return new WaitForSeconds(timeToDeactivate);
        sphereTrigger1.SetActive(false);
        sphereTrigger2.SetActive(false);
    }
}
