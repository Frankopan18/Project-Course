using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BojanjeLikovaMeni : MonoBehaviour {

	public Button pasButton;
	public Button mackaButton;
	public Button kokosButton;
	public Button pileButton;
	public Button ovcaButton;
	public Button svinjaButton;
	List<string> activeColors = new List<string>();

	
	// Use this for initialization
	void Awake () {
		
		// Check which colors are active
		if (GameObject.Find("__app").GetComponent<Varijable>().crvena == true) {
			activeColors.Add("crvena");
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().plava == true) {
			activeColors.Add("plava");
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().zelena == true) {
			activeColors.Add("zelena");
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().zuta == true) {
			activeColors.Add("zuta");
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().narancasta == true) {
			activeColors.Add("narancasta");
		}

		if (GameObject.Find("__app").GetComponent<Varijable>().ruzicasta == true) {
			activeColors.Add("ruzicasta");
		}

		// Check if atleast four colors are active
		if (activeColors.Count < 4) {

			// Warn the player he didn't select atleast 4 colors
			// Or open a new scene to display the message

			SceneManager.LoadScene("PocetnaPopUp");

			// // Debug
			// Debug.Log("Please select atleast 4 colors to continue.");
		} 
	}
	void Start () {
		
		pasButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "pas";

			// // Debug
			// string globalAnimal = GameObject.Find("__app").GetComponent<Varijable>().odabraniLik;
			// Debug.Log("Odabrani lik je " + globalAnimal);
		});

		mackaButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "macka";
		});

		kokosButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "kokos";
		});

		pileButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "pile";
		});

		ovcaButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "ovca";
		});

		svinjaButton.onClick.AddListener(() => {

			GameObject.Find("__app").GetComponent<Varijable>().odabraniLik = "svinja";
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
