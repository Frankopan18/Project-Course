using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpWindow : MonoBehaviour {

    public GameObject window;
    public Text messageField;

	public void Show()
    {
        messageField.text = "Za ovu igru trebate odabrati barem 4 boje.";
        window.SetActive(true);
    }
	
	public void Hide()
    {
        window.SetActive(false);
    }
}
