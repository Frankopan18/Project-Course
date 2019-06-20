using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour {

	void Awake() {

		// Added tutorial
		if (GameObject.Find("__app").GetComponent<Varijable>().isFirstTime) {
			
			SceneManager.LoadScene("INFO_welcome");
		} else {

			SceneManager.LoadScene("Pocetna");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
