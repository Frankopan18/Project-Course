using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class RelinkAnimals : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

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
			&& GameObject.Find("Main Camera").GetComponent<DominantnaBoja>().stage == 1000) {

			SceneManager.LoadScene("dominantna_boja");
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
