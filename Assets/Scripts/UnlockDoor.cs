using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class UnlockDoor : MonoBehaviour {

	public Image crveniBalon;
	public Image plaviBalon;
	public Image zeleniBalon;
	public Image zutiBalon;
	public Image narancastiBalon;
	public Image ruzicastiBalon;
	public Image doorClosed;
	public Image doorOpen;
	private int xOffset = 1000;
	private Vector3 crveniBalonPosition;
	private Vector3 plaviBalonPosition;
	private Vector3 zeleniBalonPosition;
	private Vector3 zutiBalonPosition;
	private Vector3 narancastiBalonPosition;
	private Vector3 ruzicastiBalonPosition;
	private int yOffset = 500;
	private float moveSpeed = 25;
	public int stage;

	// Use this for initialization
	void Start () {

		stage = 0;

		// Randomize paths of the baloons
		crveniBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
		plaviBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
		zeleniBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
		zutiBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
		narancastiBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
		ruzicastiBalonPosition = new Vector3(Random.Range(-xOffset, xOffset), yOffset, 1);
	}
	
	// Update is called once per frame
	void Update () {

		// Stage 1 is when the user clicked the right anwser
		if (stage == 1) {

			doorClosed.enabled = false;

			// Load correct picture of opened doors
			StringBuilder doorOpenImageLocation = new StringBuilder();
			doorOpenImageLocation.Append("Otkljucavanje vrata/vrata/otvorena/");
			doorOpenImageLocation.Append(GameObject.Find("__app").GetComponent<Varijable>().odabranaBojaVrata);

			doorOpen.sprite = Resources.Load<Sprite>(doorOpenImageLocation.ToString());


			// Display opened doors
			doorOpen.enabled = true;

			// Display the baloons
			crveniBalon.enabled = true;
			plaviBalon.enabled = true;
			zeleniBalon.enabled = true;
			zutiBalon.enabled = true;
			narancastiBalon.enabled = true;
			ruzicastiBalon.enabled = true;

			stage = 2;
		}

		// Stage 2 is the animation of the baloons flying out
		if (stage == 2) {

			crveniBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(crveniBalon.GetComponent<RectTransform>().position, crveniBalonPosition, moveSpeed * Time.deltaTime);
			plaviBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(plaviBalon.GetComponent<RectTransform>().position, plaviBalonPosition, moveSpeed * Time.deltaTime);
			zeleniBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(zeleniBalon.GetComponent<RectTransform>().position, zeleniBalonPosition, moveSpeed * Time.deltaTime);
			zutiBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(zutiBalon.GetComponent<RectTransform>().position, zutiBalonPosition, moveSpeed * Time.deltaTime);
			narancastiBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(narancastiBalon.GetComponent<RectTransform>().position, narancastiBalonPosition, moveSpeed * Time.deltaTime);
			ruzicastiBalon.GetComponent<RectTransform>().position = Vector3.MoveTowards(ruzicastiBalon.GetComponent<RectTransform>().position, ruzicastiBalonPosition, moveSpeed * Time.deltaTime);

			// // // Debug
			// Debug.Log(Mathf.Abs(crveniBalon.GetComponent<RectTransform>().position.y - yOffset));

			if (Mathf.Abs(crveniBalon.GetComponent<RectTransform>().position.y - yOffset) < 1 ||
				Mathf.Abs(plaviBalon.GetComponent<RectTransform>().position.y - yOffset) < 1 ||
				Mathf.Abs(zeleniBalon.GetComponent<RectTransform>().position.y - yOffset) < 1 ||
				Mathf.Abs(zutiBalon.GetComponent<RectTransform>().position.y - yOffset) < 1 ||
				Mathf.Abs(narancastiBalon.GetComponent<RectTransform>().position.y - yOffset) < 1 ||
				Mathf.Abs(ruzicastiBalon.GetComponent<RectTransform>().position.y - yOffset) < 1) {

				// // Debug
				// Debug.Log("Stage is 3!");

				stage = 1000;
			}
		}
	}
}
