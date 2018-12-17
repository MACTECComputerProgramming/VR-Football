using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManagerScript : MonoBehaviour {

    public bool correct;

    public Text text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //activates when looking at the player

    public void  pointerEnter() {
        if (correct == true)
        {
            text.text = "Correct";
        }
        else {
            text.text = "Sorry";
        }
    }
}
