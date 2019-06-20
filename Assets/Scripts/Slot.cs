using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{

    public static int counter = 0;

    public AudioSource successSound;

    public AudioSource correctSound;

    public AudioSource wrongSound;

    public GameObject item
    {
        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }
    #region IdropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (item && transform.parent.name.Contains("Color"))

        {
     //       Debug.Log("Ime itema: " + item.GetComponent<Image>().sprite.name);
            //         Debug.Log("nakon draga:" + transform.parent.GetChild(0).gameObject.GetComponent<Image>().sprite.name);
   //         Debug.Log("ime dragganog objekta:" + DragAndDropScript.DraggedInstance.gameObject.name);
            //       if (decideIfItsGood()) {
            // i ako je broj slota jednak broju odabira
            //              DragAndDropScript.DraggedInstance.SetActive(false);
            //        }

            if (decideItsGood()) {
                DragAndDropScript.DraggedInstance.transform.SetParent(transform);
                counter++;
                if (counter < 3)
                {
                    correctSound.Play();
                }
                if (counter == 3)
                {
                    // play music and reset counter
                    successSound.Play();
                    counter = 0;

                    // Allow reset button on top right corner to work correctly
                    GameObject.Find("Main Camera").GetComponent<DominantnaBoja>().stage = 1000;
                }
            } else {
                
                // User has paired wrong animal with wrong color
                if (!wrongSound.isPlaying) {
                    wrongSound.Play();
                }
            }
        }
    }

    private bool decideItsGood()
    {
        if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("pile") && item.GetComponent<Image>().sprite.name.Equals("zuta"))
        {
            return true;
        }
        else if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("papiga") && item.GetComponent<Image>().sprite.name.Equals("crvena"))
        {
            return true;
        }
        else if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("riba") && item.GetComponent<Image>().sprite.name.Equals("plava"))
        {
            return true;
        }
        else if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("svinja") && item.GetComponent<Image>().sprite.name.Equals("ruzicasta"))
        {
            return true;
        }
        else if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("macka") && item.GetComponent<Image>().sprite.name.Equals("narancasta"))
        {
            return true;
        }
        else if (DragAndDropScript.DraggedInstance.GetComponent<Image>().sprite.name.Equals("zaba") && item.GetComponent<Image>().sprite.name.Equals("zelena"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


    #endregion