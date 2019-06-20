using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class tutorialReset : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	bool isPressed = false;
	int MillisecondsToActivate = 950;
	DateTime startTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isPressed == true && DateTime.Now.Subtract(startTime).Milliseconds > MillisecondsToActivate) {

			// Activate
			SceneManager.LoadScene("Postavke");

			// Reset, must be here
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
