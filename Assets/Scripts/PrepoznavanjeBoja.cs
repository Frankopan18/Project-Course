using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PrepoznavanjeBoja : MonoBehaviour {

	public Button mainMenu;
	// public Button nextColor;
	public Canvas crvenaCanvas;
	public Canvas plavaCanvas;
	public Canvas zelenaCanvas;
	public Canvas zutaCanvas;
	public Canvas narancastaCanvas;
	public Canvas ruzicastaCanvas;
	public Text crvenaText;
	public Text plavaText;
	public Text zelenaText;
	public Text zutaText;
	public Text narancastaText;
	public Text ruzicastaText;

	// Local variables
	List<string> activeColors = new List<string>();
	public int activeColor = 0;
	public int numberOfColors = -1;
	public bool isTextVisible = true;

	void Awake () {

		isTextVisible = GameObject.Find("__app").GetComponent<Varijable>().tekst;

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

		// Check if atleast one color is active
		if (activeColors.Count == 0) {

			// Warn the player he didn't select any colors
			// Or open a new scene
			SceneManager.LoadScene("PocetnaPopUp1");

			// // Debug
			// Debug.Log("Please select atleast one color to continue.");
		} else {

			numberOfColors = activeColors.Count;
			
			// // Debug
			// Debug.Log("Number of colors active is: " + numberOfColors);
		}

		// Solved in a separate script, and assigned to all main menu buttons
		// mainMenu.onClick.AddListener(() => {

		// 	// TODO
		// 	// 3 seconds delay to return to the main menu

		// 	SceneManager.LoadScene("Pocetna");
		// });

		// Solved in a separate script
		// nextColor.onClick.AddListener(() => {

		// 	hideColor();

		// 	// Cycle trough colors
		// 	activeColor++;
		// 	if (activeColor == numberOfColors) {
		// 		activeColor = 0;
		// 	}

		// 	showColor();
		// });
	}

	// Use this for initialization
	void Start () {

		showColor();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void showColor() {

		string colorToShow = activeColors[activeColor];

		// Physically show a color
		if (colorToShow.Trim().Equals("crvena")) {
			crvenaCanvas.enabled = true;

			if (isTextVisible) {
				crvenaText.enabled = true;
			}
		}

		if (colorToShow.Trim().Equals("plava")) {
			plavaCanvas.enabled = true;

			if (isTextVisible) {
				plavaText.enabled = true;
			}
		}

		if (colorToShow.Trim().Equals("zelena")) {
			zelenaCanvas.enabled = true;

			if (isTextVisible) {
				zelenaText.enabled = true;
			}
		}

		if (colorToShow.Trim().Equals("zuta")) {
			zutaCanvas.enabled = true;

			if (isTextVisible) {
				zutaText.enabled = true;
			}
		}

		if (colorToShow.Trim().Equals("narancasta")) {
			narancastaCanvas.enabled = true;

			if (isTextVisible) {
				narancastaText.enabled = true;
			}
		}

		if (colorToShow.Trim().Equals("ruzicasta")) {
			ruzicastaCanvas.enabled = true;

			if (isTextVisible) {
				ruzicastaText.enabled = true;
			}
		}
	}

	public void hideColor() {

		string colorToHide = activeColors[activeColor];

		// Physically hide a color
		if (colorToHide.Trim().Equals("crvena")) {
			crvenaCanvas.enabled = false;

			if (isTextVisible) {
				crvenaText.enabled = false;
			}
		}

		if (colorToHide.Trim().Equals("plava")) {
			plavaCanvas.enabled = false;

			if (isTextVisible) {
				plavaText.enabled = false;
			}
		}

		if (colorToHide.Trim().Equals("zelena")) {
			zelenaCanvas.enabled = false;

			if (isTextVisible) {
				zelenaText.enabled = false;
			}
		}

		if (colorToHide.Trim().Equals("zuta")) {
			zutaCanvas.enabled = false;

			if (isTextVisible) {
				zutaText.enabled = false;
			}
		}

		if (colorToHide.Trim().Equals("narancasta")) {
			narancastaCanvas.enabled = false;

			if (isTextVisible) {
				narancastaText.enabled = false;
			}
		}

		if (colorToHide.Trim().Equals("ruzicasta")) {
			ruzicastaCanvas.enabled = false;

			if (isTextVisible) {
				ruzicastaText.enabled = false;
			}
		}
	}
}
