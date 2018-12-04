using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGazeScript : MonoBehaviour {

    public Material lookingMaterial;
    public Material notLookingMaterial;

    public GameObject MOVE;

    void Start() {
        GetComponent<Renderer>().material = notLookingMaterial;
    }

    public void lookingSwitch() {
        GetComponent<Renderer>().material = lookingMaterial;
    }

    public void notLooking(){
        GetComponent<Renderer>().material = notLookingMaterial;
    }
    
    /*public void QBPOV()
    {
        //set Camera&*emulator to QBPOV (0.-5.-2)
        MOVE.transform.position = transform.TransformPoint(0, -5, -2);
        //set gazer distance to QB reqs(120)



    }

    public void MenuPOV()
    {
       
    }

    */
}
