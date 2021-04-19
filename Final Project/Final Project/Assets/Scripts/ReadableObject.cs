using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadableObject : MonoBehaviour
{
    public float TheDistance;
    
    private GameObject ActionKey;
    private GameObject ActionText;
    private GameObject ExtraCross;
    private GameObject Canvas;
    
    public GameObject ObjectToRead;
    public GameObject ImageToDisplay;
    public bool IsDisplayed = false;

    void Awake() {
        Canvas = GameObject.Find("Canvas");
        ActionKey = Canvas.gameObject.transform.Find("ActionKey").gameObject;
        ActionText = Canvas.gameObject.transform.Find("ActionText").gameObject;
        ExtraCross = Canvas.gameObject.transform.Find("ExtraCross").gameObject;
    }

    void Update() //check distance each frame
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        if(TheDistance <= 3 && !IsDisplayed){ //display UI information
            ActionKey.GetComponent<Text>().text = "[ E ]";
            ActionKey.SetActive(true);
            ActionText.GetComponent<Text>().text = "Read";
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }
        if(TheDistance <= 3 && IsDisplayed){ //display UI information
            ActionKey.GetComponent<Text>().text = "[ Esc ]";
            ActionKey.SetActive(true);
            ActionText.GetComponent<Text>().text = "Put Down";
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }

        if(Input.GetButtonDown("Action") && !IsDisplayed){
            if(TheDistance <= 3) {
                ImageToDisplay.SetActive(true);
                IsDisplayed = true;

                ObjectToRead.GetComponent<MeshRenderer>().enabled = false;
                
                ActionKey.GetComponent<Text>().text = "[ Esc ]";    
                ActionKey.SetActive(true);
                ActionText.GetComponent<Text>().text = "Put Down";
                ActionText.SetActive(true);
                ExtraCross.SetActive(false);

                
            }
        }

        if(Input.GetButtonDown("Cancel") && IsDisplayed){
            ImageToDisplay.SetActive(false);
            IsDisplayed = false;

            ObjectToRead.GetComponent<MeshRenderer>().enabled = true;
            
            ActionKey.SetActive(true);
            ActionKey.GetComponent<Text>().text = "[ E ]";
            ActionText.GetComponent<Text>().text = "Read";
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }
    }
    void OnMouseExit(){
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }
}
