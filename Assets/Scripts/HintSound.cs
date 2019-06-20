using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class HintSound : MonoBehaviour {
	
	public Button hintButton;
	public AudioSource crvenaZenski;
	public AudioSource crvenaMuski;
	public AudioSource plavaZenski;
	public AudioSource plavaMuski;
	public AudioSource zelenaZenski;
	public AudioSource zelenaMuski;
	public AudioSource zutaZenski;
	public AudioSource zutaMuski;
	public AudioSource narancastaZenski;
	public AudioSource narancastaMuski;
	public AudioSource ruzicastaZenski;
	public AudioSource ruzicastaMuski;


	// Use this for initialization
	void Start () {

		AudioSource activeAudioSource = new AudioSource();

		// Find out the correct color to play
		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("crvena")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = crvenaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = crvenaMuski;
			}
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("plava")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = plavaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = plavaMuski;
			}
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("zelena")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = zelenaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = zelenaMuski;
			}
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("zuta")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = zutaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = zutaMuski;
			}
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("narancasta")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = narancastaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = narancastaMuski;
			}
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata.Equals("ruzicasta")) {
			
			if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
				
				activeAudioSource = ruzicastaZenski;
			} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {

				activeAudioSource = ruzicastaMuski;
			}
		}
		
		hintButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!GameObject.Find("__app").GetComponent<Varijable>().vrataOtkljucana 
				&& !activeAudioSource.isPlaying) {

				// Play
				activeAudioSource.Play();
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
