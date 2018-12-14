using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGazeScript : MonoBehaviour {

    
    public Material lookingMaterial;
    public Material notLookingMaterial;

    

    void Start() {
        GetComponent<Renderer>().material = notLookingMaterial;
    }

    public void lookingSwitch() {
        GetComponent<Renderer>().material = lookingMaterial;
    }

    public void notLooking(){
        GetComponent<Renderer>().material = notLookingMaterial;
    }
    
}
