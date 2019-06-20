using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameMenu : MonoBehaviour {

	void Awake () {

		// Faster way of loading main menu
		//SceneManager.LoadSceneAsync("Pocetna");

		SceneManager.LoadScene("Pocetna");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
