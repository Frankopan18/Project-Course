using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class LearnNextColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	bool isPressed = false;
	int MillisecondsToActivate = 0;
	DateTime startTime;
	public PrepoznavanjeBoja prepoznavanjeBoja;
    public DominantnaBoja dominantnaBoja;

	// Use this for initialization
	void Start () {
		
		MillisecondsToActivate = GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (isPressed == true && DateTime.Now.Subtract(startTime).Milliseconds > MillisecondsToActivate) {

			// Activate
			prepoznavanjeBoja.hideColor();


			// Cycle trough colors
			prepoznavanjeBoja.activeColor++;
			if (prepoznavanjeBoja.activeColor == prepoznavanjeBoja.numberOfColors) {
				
				prepoznavanjeBoja.activeColor = 0;
			}

            prepoznavanjeBoja.showColor();

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
