using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButtons : MonoBehaviour {
    public GameObject popUpWindow;
    public Button firstButton;
    public Button secondButton;
    public Button thirdButton;
    public Button fourthButton;

    // Use this for initialization
    void Start () {
		if (popUpWindow.activeSelf)
        {
            firstButton.GetComponent<Button>().interactable = false;
            secondButton.GetComponent<Button>().interactable = false;
            thirdButton.GetComponent<Button>().interactable = false;
            fourthButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            firstButton.GetComponent<Button>().interactable = true;
            secondButton.GetComponent<Button>().interactable = true;
            thirdButton.GetComponent<Button>().interactable = true;
            fourthButton.GetComponent<Button>().interactable = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
