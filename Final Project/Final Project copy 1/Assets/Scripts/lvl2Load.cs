using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl2Load : MonoBehaviour
{
    public AudioSource elevatorDing;
    public AudioSource elevatorOpenSound;
    public GameObject FadeIn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sounds());
    }

    IEnumerator Sounds(){
        elevatorOpenSound.Play();
        FadeIn.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        elevatorDing.Play();
        FadeIn.SetActive(false);
    }
}
