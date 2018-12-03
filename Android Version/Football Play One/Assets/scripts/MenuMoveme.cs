using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMoveme : MonoBehaviour {


public GameObject menuCam;
	// Use this for initialization
	void Start ()
    {
        
        //set camera&emulator above field to menu position (0.70.18)
        menuCam.transform.position = transform.TransformPoint(0, 70, 18);

        //set gazer distance to menu reqs(20?)
		
	}
	
	// Update is called once per frame
	void QBPOV ()
    {
        //set Camera&*emulator to QBPOV (0.-5.-2)
        transform.TransformPoint(0, -5, -2);
        //set gazer distance to QB reqs(120)



    }
}
