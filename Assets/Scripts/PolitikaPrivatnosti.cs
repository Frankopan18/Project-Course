using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolitikaPrivatnosti : MonoBehaviour {

	public Button hr;
	public Button us;

	// Use this for initialization
	void Start () {

		hr.onClick.AddListener(() => {
			
			Application.OpenURL("http://www.ict-aac.hr/index.php/hr/politika-privatnosti/");
		});

		us.onClick.AddListener(() => {
			
			Application.OpenURL("http://www.ict-aac.hr/index.php/en/privacy-policy/");
		});
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
