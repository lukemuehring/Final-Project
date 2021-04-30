using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public float TheDistance;
    public GameObject subtitle;
    
    private GameObject ActionKey;
    private GameObject ActionText;
    private GameObject ExtraCross;
    private GameObject Canvas;

    public string Text1 = "Press";
    public GameObject innerButton;
    public AudioSource powerDownSound;
    public AudioSource alarmSound;
    public AudioSource warningSound;

    public GameObject Lights;
    
    private GameObject Light1;
    private GameObject LightPlane1;
    private GameObject PointLight1;

    private GameObject Light2;
    private GameObject LightPlane2;
    private GameObject PointLight2;

    private GameObject Light3;
    private GameObject LightPlane3;
    private GameObject PointLight3;

    private GameObject Light4;
    private GameObject LightPlane4;
    private GameObject PointLight4;

    private GameObject Light5;
    private GameObject LightPlane5;
    private GameObject PointLight5;

    private GameObject Light6;
    private GameObject LightPlane6;
    private GameObject PointLight6;

    private GameObject Light7;
    private GameObject LightPlane7;
    private GameObject PointLight7;

    void Awake() {
        Canvas = GameObject.Find("Canvas");
        ActionKey = Canvas.gameObject.transform.Find("ActionKey").gameObject;
        ActionText = Canvas.gameObject.transform.Find("ActionText").gameObject;
        ExtraCross = Canvas.gameObject.transform.Find("ExtraCross").gameObject;

        Light1 = Lights.gameObject.transform.GetChild(0).gameObject;
        LightPlane1 = Light1.transform.GetChild(0).gameObject;
        PointLight1 = Light1.transform.GetChild(1).gameObject;
       
        Light2 = Lights.gameObject.transform.GetChild(1).gameObject;
        LightPlane2 = Light2.transform.GetChild(0).gameObject;
        PointLight2 = Light2.transform.GetChild(1).gameObject;

        Light3 = Lights.gameObject.transform.GetChild(2).gameObject;
        LightPlane3 = Light3.transform.GetChild(0).gameObject;
        PointLight3 = Light3.transform.GetChild(1).gameObject;

        Light4 = Lights.gameObject.transform.GetChild(3).gameObject;
        LightPlane4 = Light4.transform.GetChild(0).gameObject;
        PointLight4 = Light4.transform.GetChild(1).gameObject;

        Light5 = Lights.gameObject.transform.GetChild(4).gameObject;
        LightPlane5 = Light5.transform.GetChild(0).gameObject;
        PointLight5 = Light5.transform.GetChild(1).gameObject;

        Light6 = Lights.gameObject.transform.GetChild(5).gameObject;
        LightPlane6 = Light6.transform.GetChild(0).gameObject;
        PointLight6 = Light6.transform.GetChild(1).gameObject;

        Light7 = Lights.gameObject.transform.GetChild(6).gameObject;
        LightPlane7 = Light7.transform.GetChild(0).gameObject;
        PointLight7 = Light7.transform.GetChild(1).gameObject;
    }

    void Update() //check distance each frame
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver(){
        if(TheDistance <= 3 && !PlayerCasting.isReading 
            && !PlayerCasting.hasPressedButton){ //display UI information
            ActionKey.GetComponent<Text>().text = "[ E ]";
            ActionKey.SetActive(true);
            ActionText.GetComponent<Text>().text = Text1;
            ActionText.SetActive(true);
            ExtraCross.SetActive(true);
        }

        if(Input.GetButtonDown("Action") && !PlayerCasting.isReading
            && !PlayerCasting.hasPressedButton){
            if(TheDistance <= 3) {
                PlayerCasting.hasPressedButton = true;
                powerDownSound.Play();
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                ExtraCross.SetActive(false);
                innerButton.GetComponent<Animation>().Play("buttonPressAnim");
                StartCoroutine(buttonPressed());
            }
        }


    }
    void OnMouseExit(){
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
        ExtraCross.SetActive(false);
    }

    IEnumerator buttonPressed(){
                  
            LightPlane1.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight1.GetComponent<Animation>().Play("flashingLightAnim");

            LightPlane2.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight2.GetComponent<Animation>().Play("flashingLightAnim");

            LightPlane3.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight3.GetComponent<Animation>().Play("flashingLightAnim");

            LightPlane4.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight4.GetComponent<Animation>().Play("flashingLightAnim");
            
            LightPlane5.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight5.GetComponent<Animation>().Play("flashingLightAnim");
            
            LightPlane6.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight6.GetComponent<Animation>().Play("flashingLightAnim");

            LightPlane7.GetComponent<Animation>().Play("lightTurnsRedAnim");
            PointLight7.GetComponent<Animation>().Play("flashingLightAnim");

            warningSound.Play();
            subtitle.SetActive(true);
            yield return new WaitForSeconds(2.0f);
            alarmSound.Play();
            yield return new WaitForSeconds(5.0f);
            subtitle.SetActive(false);
    }
}
