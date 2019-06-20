using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;

public class BojanjeLikova : MonoBehaviour {

	public Button leftButton;
	public Button centerButton;
	public Button rightButton;
	public Image lik;
	public Button hintSoundButton;

	// Local variables
	List<string> activeColors = new List<string>();
	private int numberOfColors = -1;
	public string leftColor = "";
	public string centerColor = "";
	public string rightColor = "";

	// Sounds
	public AudioSource bijelaSoundFemale;
	public AudioSource bijelaSoundMale;
	public AudioSource crvenaSoundFemale;
	public AudioSource crvenaSoundMale;
	public AudioSource plavaSoundFemale;
	public AudioSource plavaSoundMale;
	public AudioSource zelenaSoundFemale;
	public AudioSource zelenaSoundMale;
	public AudioSource zutaSoundFemale;
	public AudioSource zutaSoundMale;
	public AudioSource narancastaSoundFemale;
	public AudioSource narancastaSoundMale;
	public AudioSource ruzicastaSoundFemale;
	public AudioSource ruzicastaSoundMale;


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

		// Check if atleast four colors is active (Checked in parent scene)
		numberOfColors = activeColors.Count;
	}


	// Use this for initialization
	void Start () {

		// Load selected character "lik"
		StringBuilder likImageLocation = new StringBuilder();
		likImageLocation.Append("Bojanje likova/likovi/");
		likImageLocation.Append(GameObject.Find("__app").GetComponent<Varijable>().odabraniLik);
		likImageLocation.Append("/bijela");

		lik.sprite = Resources.Load<Sprite>(likImageLocation.ToString());



		// Randomize colors
		do {
			int randomInt = Random.Range(0, numberOfColors);
			leftColor = activeColors[randomInt];
		} while (leftColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika));

		do {

			int randomInt = Random.Range(0, numberOfColors);
			centerColor = activeColors[randomInt];
		} while (leftColor.Equals(centerColor) 
				|| centerColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika));

		do {

			int randomInt = Random.Range(0, numberOfColors);
			rightColor = activeColors[randomInt];
		} while (rightColor.Equals(centerColor) 
				|| rightColor.Equals(leftColor) 
				|| rightColor.Equals(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika));

		// // Debug
		// Debug.Log(leftColor + " " + centerColor + " " + rightColor);

		
		leftButton.onClick.AddListener(() => {

			DisableButtons();

			// Hide wrong buttons
			centerButton.gameObject.SetActive(false);
			rightButton.gameObject.SetActive(false);

			// Update the selected color
			GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika = leftColor;

			// Launch the painter
			GameObject.Find("Panel Paint").GetComponent<ApplyColorOnCharacter>().stage = 1;
		});
		
		centerButton.onClick.AddListener(() => {

			DisableButtons();

			// Hide wrong buttons
			leftButton.gameObject.SetActive(false);
			rightButton.gameObject.SetActive(false);

			// Update the selected color
			GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika = centerColor;

			// Launch the painter
			GameObject.Find("Panel Paint").GetComponent<ApplyColorOnCharacter>().stage = 1;
		});

		rightButton.onClick.AddListener(() => {

			DisableButtons();

			// Hide wrong buttons
			leftButton.gameObject.SetActive(false);
			centerButton.gameObject.SetActive(false);

			// Update the selected color
			GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika = rightColor;

			// Launch the painter
			GameObject.Find("Panel Paint").GetComponent<ApplyColorOnCharacter>().stage = 1;
		});

		// Placeholder audio source that contains current color
		AudioSource activeAudioSource = new AudioSource();

		hintSoundButton.onClick.AddListener(() => {

			if (GameObject.Find("Panel Paint").GetComponent<ApplyColorOnCharacter>().stage == 0) {

				// Find out if selected voice is male or female
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {

					// Odabran je zenski glas
					if (!bijelaSoundFemale.isPlaying) {
						bijelaSoundFemale.Play();
					}
				} else {

					// Odabran je muski glas
					if (!bijelaSoundMale.isPlaying) {
						bijelaSoundMale.Play();
					}
				}
			}

			if (GameObject.Find("Panel Paint").GetComponent<ApplyColorOnCharacter>().stage == 1000) {

				// Find out if selected voice is male or female
				if (GameObject.Find("__app").GetComponent<Varijable>().glas == 0) {

					// Koja je boja odabrana
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("crvena")) { activeAudioSource = crvenaSoundFemale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("plava")) { activeAudioSource = plavaSoundFemale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("zelena")) { activeAudioSource = zelenaSoundFemale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("zuta")) { activeAudioSource = zutaSoundFemale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("narancasta")) { activeAudioSource = narancastaSoundFemale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("ruzicasta")) { activeAudioSource = ruzicastaSoundFemale; }

					if (!activeAudioSource.isPlaying) {
						activeAudioSource.Play();
					}
				} else {

					// Odabran je muski glas
					if (!bijelaSoundMale.isPlaying) {

					// Koja je boja odabrana
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("crvena")) { activeAudioSource = crvenaSoundMale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("plava")) { activeAudioSource = plavaSoundMale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("zelena")) { activeAudioSource = zelenaSoundMale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("zuta")) { activeAudioSource = zutaSoundMale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("narancasta")) { activeAudioSource = narancastaSoundMale; }
					if (GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika.Equals("ruzicasta")) { activeAudioSource = ruzicastaSoundMale; }

					if (!activeAudioSource.isPlaying) {
						activeAudioSource.Play();
					}
					}
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
