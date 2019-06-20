using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialCompleted : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		PlayerPrefs.SetInt("isFirstTime", 0);
		GameObject.Find("__app").GetComponent<Varijable>().isFirstTime = false;
		PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
