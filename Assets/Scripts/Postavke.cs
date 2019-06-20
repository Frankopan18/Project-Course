using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Postavke : MonoBehaviour {

	public Toggle crvena;
	public Toggle plava;
	public Toggle zelena;
	public Toggle zuta;
	public Toggle narancasta;
	public Toggle ruzicasta;
	public Toggle tekst;
	public Dropdown glas;
	public Toggle accessibilityMode;

	public Button pocetna;

	void Awake () {

		loadGlobals();
	}

	// Use this for initialization
	void Start () {

		crvena.onValueChanged.AddListener((KeyValuePair) => {

			// // Debug
			// Debug.Log("String: " + KeyValuePair.ToString());
			// Debug.Log("Integer reprezentacija je: " + boolToInt(KeyValuePair).ToString());

			PlayerPrefs.SetInt("crvena", boolToInt(KeyValuePair));

			GameObject.Find("__app").GetComponent<Varijable>().crvena = KeyValuePair;

			// // Debug
			// Debug.Log("Spremljena vrijednost jest: " + PlayerPrefs.GetInt("crvena"));
		});

		plava.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("plava", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().plava = KeyValuePair;
		});

		zelena.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("zelena", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().zelena = KeyValuePair;
		});

		zuta.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("zuta", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().zuta = KeyValuePair;
		});

		narancasta.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("narancasta", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().narancasta = KeyValuePair;
		});

		ruzicasta.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("ruzicasta", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().ruzicasta = KeyValuePair;
		});

		tekst.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("tekst", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().tekst = KeyValuePair;
		});

		glas.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("glas", KeyValuePair);
			GameObject.Find("__app").GetComponent<Varijable>().glas = KeyValuePair;
		});

		accessibilityMode.onValueChanged.AddListener((KeyValuePair) => {

			PlayerPrefs.SetInt("accessibilityMode", boolToInt(KeyValuePair));
			GameObject.Find("__app").GetComponent<Varijable>().accessibilityMode = KeyValuePair;

			// Update global variables
			if (KeyValuePair) {
				GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate
				= GameObject.Find("__app").GetComponent<Varijable>().MillisecondsToActivateHold;
			} else {
				GameObject.Find("__app").GetComponent<Varijable>().millisecondsToActivate
				= GameObject.Find("__app").GetComponent<Varijable>().MillisecondsToActivateQuick;
			}
		});

		pocetna.onClick.AddListener(() => {
			
			// // Debug
			// Debug.Log("Prije save-anja vrijednost je: " + intToBool(PlayerPrefs.GetInt("crvena", 1)));
			
			// Write PlayerPrefs to disk
			PlayerPrefs.Save();

			// // Debug
			// Debug.Log("Poslije save-anja vrijednost je: " + intToBool(PlayerPrefs.GetInt("crvena", 1)));
			
			// SceneManager.LoadScene("Pocetna");
		});
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	private int boolToInt (bool KeyValuePair) {
		return (KeyValuePair == true) ? 1 : 0;
	}

	private bool intToBool (int KeyValuePair) {
		return (KeyValuePair == 1) ? true : false;
	}

	private void loadGlobals () {

		crvena.isOn = GameObject.Find("__app").GetComponent<Varijable>().crvena;
		plava.isOn = GameObject.Find("__app").GetComponent<Varijable>().plava;
		zelena.isOn = GameObject.Find("__app").GetComponent<Varijable>().zelena;
		zuta.isOn = GameObject.Find("__app").GetComponent<Varijable>().zuta;
		narancasta.isOn = GameObject.Find("__app").GetComponent<Varijable>().narancasta;
		ruzicasta.isOn = GameObject.Find("__app").GetComponent<Varijable>().ruzicasta;
		tekst.isOn = GameObject.Find("__app").GetComponent<Varijable>().tekst;
		glas.value = GameObject.Find("__app").GetComponent<Varijable>().glas;
		accessibilityMode.isOn = GameObject.Find("__app").GetComponent<Varijable>().accessibilityMode;
		
		// // Debug
		// bool globalValue = GameObject.Find("__app").GetComponent<Varijable>().crvena;
		// bool localValue = crvena.isOn;
		// Debug.Log("Global: " + globalValue + " | Local: " + localValue);
	}
}
