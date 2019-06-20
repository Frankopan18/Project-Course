using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class OtkljucavanjeVrataGame : MonoBehaviour {

	public OtkljucavanjeVrata otkljucavanjeVrata;

	public Button leftButton;
	public Button centerButton;
	public Button rightButton;


	// Use this for initialization
	void Start () {

		// Left Button
		StringBuilder leftButtonLocation = new StringBuilder();
		leftButtonLocation.Append("Otkljucavanje vrata/kljucevi/");
		leftButtonLocation.Append(otkljucavanjeVrata.leftColor);

		leftButton.image.sprite = Resources.Load<Sprite>(leftButtonLocation.ToString());

		// Center Button
		StringBuilder centerButtonLocation = new StringBuilder();
		centerButtonLocation.Append("Otkljucavanje vrata/kljucevi/");
		centerButtonLocation.Append(otkljucavanjeVrata.centerColor);

		centerButton.image.sprite = Resources.Load<Sprite>(centerButtonLocation.ToString());

		// Right Button
		StringBuilder rightButtonLocation = new StringBuilder();
		rightButtonLocation.Append("Otkljucavanje vrata/kljucevi/");
		rightButtonLocation.Append(otkljucavanjeVrata.rightColor);

		rightButton.image.sprite = Resources.Load<Sprite>(rightButtonLocation.ToString());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
