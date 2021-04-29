using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CluesInteract : MonoBehaviour
{

    public GameObject textBox;
    public GameObject captionBox;
    [SerializeField] public RawImage customImage;
    public bool isReading = false;
    public bool onTrigger = false;
    public static int cluesFound = 0;
    public bool keyActive = false;

    public bool clue1 = false;
    public bool clue2 = false;
    public bool clue3 = false;
    public bool clue4 = false;
    public bool clue5 = false;
    
    private void Start() {
        textBox.GetComponent<Text>().text = "";
        captionBox.GetComponent<Text>().text = "";

    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && onTrigger) {
            if (!isReading) {
                customImage.enabled = true;
                textBox.GetComponent<Text>().text = "";
                isReading = true;
                if (this.gameObject.tag == "ActivityLog") {
                    captionBox.GetComponent<Text>().text = "They have been tracking my activity...everyday...";
                    clueCount(clue1);
                    clue1 = true;
                } else if (this.gameObject.tag == "Sitting") {
                    captionBox.GetComponent<Text>().text = "This is...me? Ok this is getting weird and slightly terrifying";
                    clueCount(clue2);
                    clue2 = true;
                } else if (this.gameObject.tag == "Running") {
                    captionBox.GetComponent<Text>().text = "Me again. What the hell is going on here.";
                    clueCount(clue3);
                    clue3 = true;
                } else if (this.gameObject.tag == "Blueprint") {
                    captionBox.GetComponent<Text>().text = "It seems they were going over the blueprints to my house";
                    clueCount(clue4);
                    clue4 = true;
                } else if (this.gameObject.tag == "Bench") {
                    captionBox.GetComponent<Text>().text = "There must be a reason these guys were following my life so closely. I have to get to the bottom of this.";
                    clueCount(clue5);
                    clue5 = true;
                }
            } else {
                customImage.enabled = false;
                isReading = false;
                captionBox.GetComponent<Text>().text = "";
            }
        }
    }
   
    public void OnTriggerEnter(Collider other) {
        textBox.GetComponent<Text>().text = "Press E to inspect clue.";
        onTrigger = true;
    }

    public void OnTriggerExit(Collider other) {
        textBox.GetComponent<Text>().text = "";
        customImage.enabled = false;
        onTrigger = false;

    }

    public void clueCount(bool alreadyLooked) {
        if (!alreadyLooked) {
            cluesFound++;
        }
    }
    
}
