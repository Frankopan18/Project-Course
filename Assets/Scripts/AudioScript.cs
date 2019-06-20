using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class AudioScript : MonoBehaviour {
	
	public Button crvenaButton;
	public AudioSource crvenaZenski;
	public AudioSource crvenaMuski;

	public Button plavaButton;
	public AudioSource plavaZenski;
	public AudioSource plavaMuski;

	public Button zelenaButton;
	public AudioSource zelenaZenski;
	public AudioSource zelenaMuski;

	public Button zutaButton;
	public AudioSource zutaZenski;
	public AudioSource zutaMuski;

	public Button narancastaButton;
	public AudioSource narancastaZenski;
	public AudioSource narancastaMuski;

	public Button ruzicastaButton;
	public AudioSource ruzicastaZenski;
	public AudioSource ruzicastaMuski;


	// Use this for initialization
	void Start () {
		
		crvenaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!crvenaZenski.isPlaying && !crvenaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					crvenaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					crvenaMuski.Play();
				}
			}
		});

		plavaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!plavaZenski.isPlaying && !plavaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					plavaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					plavaMuski.Play();
				}
			}
		});

		zelenaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!zelenaZenski.isPlaying && !zelenaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					zelenaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					zelenaMuski.Play();
				}
			}
		});

		zutaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!zutaZenski.isPlaying && !zutaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					zutaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					zutaMuski.Play();
				}
			}
		});

		narancastaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!narancastaZenski.isPlaying && !narancastaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					narancastaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					narancastaMuski.Play();
				}
			}
		});

		ruzicastaButton.onClick.AddListener(() => {

			// If nothing's playing
			if (!ruzicastaZenski.isPlaying && !ruzicastaMuski.isPlaying) {

				// Play
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {
					ruzicastaZenski.Play();
				} else if (GameObject.Find("__app").GetComponent<Varijable>().glas == 1) {
					ruzicastaMuski.Play();
				}
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
