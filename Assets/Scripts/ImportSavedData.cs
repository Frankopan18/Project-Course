using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImportSavedData : MonoBehaviour {

	void Awake () {

		// Load saved data
		bool accessibilityModeSaved = intToBool(PlayerPrefs.GetInt("accessibilityMode", 0));

		if (accessibilityModeSaved) {
			GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate
			= GameObject.Find("__app").GetComponent<Varijable>().MillisecondsToActivateHold;
		} else {
			GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate
			= GameObject.Find("__app").GetComponent<Varijable>().MillisecondsToActivateQuick;
		}
		
		bool isFirstTimeSaved = intToBool(PlayerPrefs.GetInt("isFirstTime", 1));
		bool crvenaSaved = intToBool(PlayerPrefs.GetInt("crvena", 1));
		bool plavaSaved = intToBool(PlayerPrefs.GetInt("plava", 1));
		bool zelenaSaved = intToBool(PlayerPrefs.GetInt("zelena", 1));
		bool zutaSaved = intToBool(PlayerPrefs.GetInt("zuta", 1));
		bool narancastaSaved = intToBool(PlayerPrefs.GetInt("narancasta", 1));
		bool ruzicastaSaved = intToBool(PlayerPrefs.GetInt("ruzicasta", 1));
		bool tekstSaved = intToBool(PlayerPrefs.GetInt("tekst", 1));
		int glasSaved = PlayerPrefs.GetInt("glas", 0);

		// Assign values to global variables
		GameObject.Find("__app").GetComponent<Varijable>().accessibilityMode = accessibilityModeSaved;
		GameObject.Find("__app").GetComponent<Varijable>().isFirstTime = isFirstTimeSaved;
		GameObject.Find("__app").GetComponent<Varijable>().crvena = crvenaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().plava = plavaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().zelena = zelenaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().zuta = zutaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().narancasta = narancastaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().ruzicasta = ruzicastaSaved;
		GameObject.Find("__app").GetComponent<Varijable>().tekst = tekstSaved;
		GameObject.Find("__app").GetComponent<Varijable>().glas = glasSaved;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private bool intToBool (int KeyValuePair) {
		return (KeyValuePair == 1) ? true : false;
	}
}
