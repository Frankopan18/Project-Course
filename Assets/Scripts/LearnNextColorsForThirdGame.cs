using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;

public class LearnNextColorsForThirdGame : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    bool isPressed = false;
    int MillisecondsToActivate = 800;
    DateTime startTime;
    public DominantnaBoja dominantnaBoja;
    public static int activeColor = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (isPressed == true && DateTime.Now.Subtract(startTime).Milliseconds > MillisecondsToActivate)
        {

            // Cycle trough colors
            activeColor++;
            if (activeColor == dominantnaBoja.numberOfColors)
            {

                activeColor = 0;
            }

            dominantnaBoja.colorToHide3 = dominantnaBoja.colorToHide2;
            dominantnaBoja.colorToHide2 = dominantnaBoja.colorToHide1;
            dominantnaBoja.colorToHide1 = dominantnaBoja.activeColors[activeColor];

           dominantnaBoja.showColor();
            dominantnaBoja.showColor1();           
            dominantnaBoja.showColor2();

            SceneManager.LoadScene("dominantna_boja");

            // loadati jos likove

            // Reset, must be here
            isPressed = false;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        startTime = DateTime.Now;
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {

        isPressed = false;
    }
}
