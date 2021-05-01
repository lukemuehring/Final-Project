using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequence : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject loadText;
    public AudioSource buttonClick;
    //public AudioSource voiceover;
    public GameObject muteText;
    public GameObject muteButton;
    
    bool isPlayingVO;

    void Awake() {
        StartCoroutine(playVO());
    }

    public void StartButton(){
        StartCoroutine(NewGameStart());
    }
    IEnumerator NewGameStart(){
        fadeOut.SetActive(true);
        buttonClick.Play();
        loadText.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
    }

    IEnumerator playVO(){
        yield return new WaitForSeconds(3.0f);
        muteButton.SetActive(true);
        isPlayingVO = true;
        //voiceover.Play();
    }

    // public void MuteButton(){
    //     if(isPlayingVO) {
    //         voiceover.Pause();
    //         isPlayingVO = false;
    //         muteText.GetComponent<Text>().text = "Unmute Voiceover";
    //     } else {
    //         voiceover.Play();
    //         isPlayingVO = true;
    //         muteText.GetComponent<Text>().text = "Mute Voiceover";
    //     }
    // }
}
