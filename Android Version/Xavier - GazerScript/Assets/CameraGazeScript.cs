using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraGazeScript : MonoBehaviour {

    public Material lookingMaterial;
    public Material notLookingMaterial;
	public bool choice;
	public Text UI_Text;

    void Start() {
        GetComponent<Renderer>().material = notLookingMaterial;
    }

    public void lookingSwitch() {
        GetComponent<Renderer>().material = lookingMaterial;

		if (choice == true) {
			UI_Text.text = "Correct";
		} else {
			UI_Text.text = "Sorry";
		}
    }

    public void notLooking(){
        GetComponent<Renderer>().material = notLookingMaterial;
    }
	
}
