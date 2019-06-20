using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Varijable : MonoBehaviour {

	// Accessibility mode
	public bool accessibilityMode = false;
	public int millisecondsToActivate = 0;

	// Constants
	public int MillisecondsToActivateHold = 950;
	public int MillisecondsToActivateQuick = 0;

	public bool isFirstTime = true;

	public bool crvena = false;
	public bool plava = false;
	public bool zelena = false;
	public bool zuta = false;
	public bool narancasta = false;
	public bool ruzicasta = false;
	public bool tekst = false;
	public int glas = 0;

	// Trenutni odabrani lik u igri obojaj lika
	public string odabraniLik = "";
	public string odabranaBojaLika = "";

	// Trenutna odabrana vrata u igri otkljucaj vrata
	public string odabranaBojaVrata = "";
	public bool vrataOtkljucana = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
