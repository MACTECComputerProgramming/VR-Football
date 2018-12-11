using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BTN_GazerScript : MonoBehaviour {

	public Button button;
	float time;
	float timeStop = 4.0f;
	bool looking = false;



	void Start(){
		button = GetComponent<Button> ();

	}

	void Update(){
		//constantly checks to see if your looking
		if (looking == true) {
			time += Time.deltaTime;
			//Debug.Log (time);
			if (time >= timeStop) {
				Debug.Log ("Button clicked");
				time = 0f;
				ExecuteEvents.Execute (gameObject, new GvrPointerEventData (EventSystem.current), ExecuteEvents.pointerDownHandler);
			}
		}

	}

	//only fires when you are looking at an object 
	public void Looking(){
		looking = true;
		Debug.Log ("Looking");

	}

	//cancels the looking scripts
	public void NonLooking(){
		looking = false;
		Debug.Log ("Exit");
	}

	public void changeScene(int scene){
		Debug.Log ("Pointer down");
		SceneManager.LoadScene (scene);
	}
}
