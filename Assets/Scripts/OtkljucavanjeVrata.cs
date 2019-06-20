using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;

public class OtkljucavanjeVrata : MonoBehaviour {

	public Button leftButton;
	public Button centerButton;
	public Button rightButton;
	public Image doorClosed;
	public AudioSource krivoSound;
	public AudioSource tocnoSound;
	public AudioSource doorSound;
	public AudioSource applauseSound;
	public AudioSource fanfareSound;

	// Local variables
	List<string> activeColors = new List<string>();
	private int numberOfColors = -1;
	public string leftColor = "";
	public string centerColor = "";
	public string rightColor = "";


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

		// Check if atleast four color is active
		if (activeColors.Count < 4) {

			// Warn the player he didn't select atleast 4 colors
			// Or open a new scene to display the message

			SceneManager.LoadScene("PocetnaPopUp");

			// Debug
			// Debug.Log("Please select atleast 3 colors to continue.");
		} else {

			numberOfColors = activeColors.Count;
			
			// // Debug
			// Debug.Log("Number of colors active is: " + numberOfColors);
		}
	}


	// Use this for initialization
	void Start () {

		// Flush flag that plays sound on click on the door
		GameObject.Find("__app").GetComponent<Varijable>().vrataOtkljucana = false;

		// Randomize colors
		do {
			int randomInt = Random.Range(0, numberOfColors);
			leftColor = activeColors[randomInt];
		} while (leftColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata));

		do {

			int randomInt = Random.Range(0, numberOfColors);
			centerColor = activeColors[randomInt];
		} while (leftColor.Equals(centerColor) 
				|| centerColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata));

		do {

			int randomInt = Random.Range(0, numberOfColors);
			rightColor = activeColors[randomInt];
		} while (rightColor.Equals(centerColor) 
				|| rightColor.Equals(leftColor) 
				|| rightColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata));

		// // Debug
		// Debug.Log(leftColor + " " + centerColor + " " + rightColor);

		// Load randomly selected door color into door placeholder
		int randomInt2 = Random.Range(1, 4);
		string tocnaBojaVrata = "";

		if (randomInt2 == 1) {
			tocnaBojaVrata = leftColor;
		}

		if (randomInt2 == 2) {
			tocnaBojaVrata = centerColor;
		}

		if (randomInt2 == 3) {
			tocnaBojaVrata = rightColor;
		}

		GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata = tocnaBojaVrata;

		StringBuilder doorClosedImageLocation = new StringBuilder();
		doorClosedImageLocation.Append("Otkljucavanje vrata/vrata/zatvorena/");
		doorClosedImageLocation.Append(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata);

		doorClosed.sprite = Resources.Load<Sprite>(doorClosedImageLocation.ToString());

		// GAME LOGICK
		
		leftButton.onClick.AddListener(() => {

			if (leftColor.Equals(tocnaBojaVrata)) {

				// Enable flag that prevents hints when clicking on the door
				GameObject.Find("__app").GetComponent<Varijable>().vrataOtkljucana = true;

				DisableButtons();

				// Hide wrong buttons
				centerButton.gameObject.SetActive(false);
				rightButton.gameObject.SetActive(false);

				// Stop playing bad sound [if it's playing]
				if (krivoSound.isPlaying) {
					krivoSound.Stop();
				}

				// Play congratulations sound
				// tocnoSound.Play();
				doorSound.Play();
				applauseSound.Play();
				fanfareSound.Play();

				// Launch the painter
				GameObject.Find("Panel Door").GetComponent<UnlockDoor>().stage = 1;
			} else {

				if (!krivoSound.isPlaying) {
				krivoSound.Play();
				}
			}
		});
		
		centerButton.onClick.AddListener(() => {

			if (centerColor.Equals(tocnaBojaVrata)) {

				// Enable flag that prevents hints when clicking on the door
				GameObject.Find("__app").GetComponent<Varijable>().vrataOtkljucana = true;

				DisableButtons();

				// Hide wrong buttons
				leftButton.gameObject.SetActive(false);
				rightButton.gameObject.SetActive(false);

				// Stop playing bad sound [if it's playing]
				if (krivoSound.isPlaying) {
					krivoSound.Stop();
				}

				// Play congratulations sound
				// tocnoSound.Play();
				doorSound.Play();
				applauseSound.Play();
				fanfareSound.Play();

				// Launch the painter
				GameObject.Find("Panel Door").GetComponent<UnlockDoor>().stage = 1;
			} else {

				if (!krivoSound.isPlaying) {
				krivoSound.Play();
				}
			}
		});

		rightButton.onClick.AddListener(() => {

			if (rightColor.Equals(tocnaBojaVrata)) {

				// Enable flag that prevents hints when clicking on the door
				GameObject.Find("__app").GetComponent<Varijable>().vrataOtkljucana = true;

				DisableButtons();

				// Hide wrong buttons
				leftButton.gameObject.SetActive(false);
				centerButton.gameObject.SetActive(false);

				// Stop playing bad sound [if it's playing]
				if (krivoSound.isPlaying) {
					krivoSound.Stop();
				}

				// Play congratulations sound
				// tocnoSound.Play();
				doorSound.Play();
				applauseSound.Play();
				fanfareSound.Play();

				// Launch the painter
				GameObject.Find("Panel Door").GetComponent<UnlockDoor>().stage = 1;
			} else {

				if (!krivoSound.isPlaying) {
				krivoSound.Play();
				}
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DisableButtons () {

		leftButton.enabled = false;
		centerButton.enabled = false;
		rightButton.enabled = false;
	}
}
