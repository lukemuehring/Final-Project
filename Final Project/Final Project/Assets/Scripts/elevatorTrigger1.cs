using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class elevatorTrigger1 : MonoBehaviour
{
    public GameObject textBox;

    public void OnTriggerEnter(Collider collider) {
        //textBox.GetComponent<Text>().text = "I need to investigate more...";

        if (CluesInteract.cluesFound >= 5) {
            SceneManager.LoadScene(2);
        } else {
            textBox.GetComponent<Text>().text = "I need to investigate more...";
        }
    }
    
    public void OnTriggerExit(Collider collider) {
        textBox.GetComponent<Text>().text = "";
    }
}
