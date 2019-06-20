using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class BojanjeLikovaGame : MonoBehaviour {

	public BojanjeLikova bojanjeLikova;

	public Button leftButton;
	public Button centerButton;
	public Button rightButton;
	public Text leftButtonText;
	public Text centerButtonText;
	public Text rightButtonText;

	// Use this for initialization
	void Start () {

		

		// Left Button
		StringBuilder leftButtonLocation = new StringBuilder();
		leftButtonLocation.Append("Bojanje likova/tipke/");
		leftButtonLocation.Append(bojanjeLikova.leftColor);

		leftButton.image.sprite = Resources.Load<Sprite>(leftButtonLocation.ToString());

		// Center Button
		StringBuilder centerButtonLocation = new StringBuilder();
		centerButtonLocation.Append("Bojanje likova/tipke/");
		centerButtonLocation.Append(bojanjeLikova.centerColor);

		centerButton.image.sprite = Resources.Load<Sprite>(centerButtonLocation.ToString());

		// Right Button
		StringBuilder rightButtonLocation = new StringBuilder();
		rightButtonLocation.Append("Bojanje likova/tipke/");
		rightButtonLocation.Append(bojanjeLikova.rightColor);

		rightButton.image.sprite = Resources.Load<Sprite>(rightButtonLocation.ToString());
		
		// Future feature, if text should be needed
		leftButtonText.text = bojanjeLikova.leftColor;
		centerButtonText.text = bojanjeLikova.centerColor;
		rightButtonText.text = bojanjeLikova.rightColor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
