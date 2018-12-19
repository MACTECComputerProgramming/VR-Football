using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ManagerScript : MonoBehaviour {

    public bool correct;

	public Image image;
	public Sprite UI_Correct;
	public Sprite UI_Incorrect;

	// Use this for initialization
	void Start () {
		image.GetComponent<Image> ().sprite = UI_Incorrect;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //activates when looking at the player

    public void  pointerEnter() {
		if (correct == false) {
			image.sprite = UI_Incorrect;
		} else {
			image.sprite = UI_Correct;
		}
    }
}
