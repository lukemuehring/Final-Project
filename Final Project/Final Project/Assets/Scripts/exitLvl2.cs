using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitLvl2 : MonoBehaviour
{
    public GameObject fadeOut;
     
    void OnTriggerEnter(Collider other){
        if(PlayerCasting.hasPressedButton){
            StartCoroutine(loadEnding());
        }
    }
    IEnumerator loadEnding(){
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(3);
    }
}
