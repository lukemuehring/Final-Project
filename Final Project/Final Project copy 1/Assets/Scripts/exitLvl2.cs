using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class exitLvl2 : MonoBehaviour
{
    public GameObject fadeOut;
    public AudioSource elevatorCloseSound;
     
    void OnTriggerEnter(Collider other){
        if(PlayerCasting.hasPressedButton && other.gameObject.CompareTag("Player")){
            StartCoroutine(loadEnding());
        }
    }
    IEnumerator loadEnding(){
        fadeOut.SetActive(true);
        elevatorCloseSound.Play();
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene(3);
    }
}
