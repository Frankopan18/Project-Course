using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class ReopenDoor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	bool isPressed = false;
	int MillisecondsToActivate = 0;
	DateTime startTime;

	// Use this for initialization
	void Start () {
		
		MillisecondsToActivate = GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isPressed == true 
			&& DateTime.Now.Subtract(startTime).Milliseconds > MillisecondsToActivate
			&& GameObject.Find("Panel Door").GetComponent<UnlockDoor>().stage >= 2) {

			SceneManager.LoadScene("Otkljucavanje vrata");
			isPressed = false;
		}
	}

	public void OnPointerDown (PointerEventData eventData) {

		startTime = DateTime.Now;
		isPressed = true;
	}

	public void OnPointerUp (PointerEventData eventData) {

		isPressed = false;
	}
}
