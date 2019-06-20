using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;
using System;

public class DisableAllButtons : MonoBehaviour {

    public Button leftButtons;
    public Button centerButtons;
    public Button rightButtons;
    public Button okButton;
    public Button backButtons;
    public Button settingsButtons;



    void Start()
    {

        leftButtons.enabled = false;
        centerButtons.enabled = false;
        rightButtons.enabled = false;
        backButtons.enabled = false;
        settingsButtons.enabled = false;
        okButton.onClick.AddListener(() => {
            
            SceneManager.LoadScene("Pocetna");
        });
    }
}
