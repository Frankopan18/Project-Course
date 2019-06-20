using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class ApplyColorOnCharacter : MonoBehaviour {

	public RectTransform painterPanel;
	public Image lik;
	public Image paint;
	public AudioSource sprayShake;
	public AudioSource spraySound;
	private Vector2 centerPosition;
	private int zOffset = 50;
	private Vector2 upperLeftZPosition;
	private Vector2 upperRightZPosition;
	private Vector2 lowerLeftZPosition;
	private Vector2 lowerRightZPosition;
	private Vector2 idlePosition = new Vector2(-500, 100);
	private float moveSpeed = 500;
	public int stage;

	// Animal sounds
	public AudioSource pasSound;
	public AudioSource mackaSound;
	public AudioSource kokosSound;
	public AudioSource pileSound;
	public AudioSource ovcaSound;
	public AudioSource svinjaSound;

	// Use this for initialization
	void Start () {

		// Play animal sound
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("pas")) pasSound.Play();
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("macka")) mackaSound.Play();
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("kokos")) kokosSound.Play();
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("pile")) pileSound.Play();
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("ovca")) ovcaSound.Play();
		if (GameObject.Find("__app").GetComponent<Varijable>().odabraniLik.Equals("svinja")) svinjaSound.Play();

		stage = 0;

		upperLeftZPosition = new Vector2(centerPosition.x - zOffset, centerPosition.y + 0);
		upperRightZPosition = new Vector2(centerPosition.x + zOffset, centerPosition.y + 0);
		lowerLeftZPosition = new Vector2(centerPosition.x - zOffset, centerPosition.y - zOffset);
		lowerRightZPosition = new Vector2(centerPosition.x + zOffset, centerPosition.y - zOffset);
		
		// Save center position
		centerPosition = painterPanel.offsetMin;

		// Position the painterPanel to idle position
		painterPanel.offsetMin = idlePosition;
	}
	
	// Update is called once per frame
	void Update () {

		// Stage 1, From idle position to Upper Left corner of 'Z'
		if (stage == 1) {

			if (!sprayShake.isPlaying) {
				sprayShake.Play();
			}
			
			painterPanel.offsetMin = Vector2.MoveTowards(painterPanel.offsetMin, upperLeftZPosition, moveSpeed * Time.deltaTime);

			if (painterPanel.offsetMin.Equals(upperLeftZPosition)) {

				// Enable paint
				paint.enabled = true;
				spraySound.Play();

				stage = 2;

				// Load selected character "paint circle" in various colors
				StringBuilder paintImageLocation = new StringBuilder();
				paintImageLocation.Append("Bojanje likova/boja/");
				string odabranaBoja = GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika;
				paintImageLocation.Append(odabranaBoja);

				// // Debug
				// Debug.Log(paintImageLocation);
				
				paint.sprite = Resources.Load<Sprite>(paintImageLocation.ToString());
			}
		}

		// Stage2, From Upper Left corner to Upper Right corner of 'Z'
		if (stage == 2) {

			painterPanel.offsetMin = Vector2.MoveTowards(painterPanel.offsetMin, upperRightZPosition, moveSpeed * Time.deltaTime);

			if (painterPanel.offsetMin.Equals(upperRightZPosition)) {

				stage = 3;
			}
		}

		// Stage3, From Upper Right corner to Lower Left corner of 'Z'
		if (stage == 3) {

			painterPanel.offsetMin = Vector2.MoveTowards(painterPanel.offsetMin, lowerLeftZPosition, moveSpeed * Time.deltaTime);

			if (painterPanel.offsetMin.Equals(lowerLeftZPosition)) {

				stage = 4;

				// Change image

				// Load selected character "lik" in various colors
				StringBuilder likImageLocation = new StringBuilder();
				likImageLocation.Append("Bojanje likova/likovi/");
				likImageLocation.Append(GameObject.Find("__app").GetComponent<Varijable>().odabraniLik);
				likImageLocation.Append("/");
				string odabranaBoja = GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaLika;
				likImageLocation.Append(odabranaBoja);
				
				lik.sprite = Resources.Load<Sprite>(likImageLocation.ToString());
				
			}
		}

		// Stage4, From Lower Left corner of 'Z' to Lower right corner of 'Z'
		if (stage == 4) {

			painterPanel.offsetMin = Vector2.MoveTowards(painterPanel.offsetMin, lowerRightZPosition, moveSpeed * Time.deltaTime);

			if (painterPanel.offsetMin.Equals(lowerRightZPosition)) {

				// Disable paint
				paint.enabled = false;
				spraySound.Stop();

				stage = 5;
			}
		}

		// Stage5, From Lower right corner of 'Z' to Idle position
		if (stage == 5) {

			painterPanel.offsetMin = Vector2.MoveTowards(painterPanel.offsetMin, idlePosition, moveSpeed * Time.deltaTime);

			if (painterPanel.offsetMin.Equals(idlePosition)) {

				stage = 1000;
			}
		}
	}
}
