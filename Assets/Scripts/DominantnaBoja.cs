using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;
using System.Text;

public class DominantnaBoja : MonoBehaviour
{
    public int firstChoice = 0;
    public int secondChoice = 0;
    public int thirdChoice = 0;
    public HashSet<int> allChoices = new HashSet<int>();
    public Image prvaBoja;
    public Image drugaBoja;
    public Image trecaBoja;
    public Image prvaZivotinja;
    public Image drugaZivotinja;
    public Image trecaZivotinja;
    // Local variables
    public List<string> activeColors = new List<string>();
    public string colorToHide1 = "";
    public string colorToHide2 = "";
    public string colorToHide3 = "";
    public int numberOfColors = -1;
    public bool isTextVisible = true;
    public int stage = 0;


    void Awake()
    {
        stage = 1;
        
        getActiveColors();

        // broj puta je 0,a ne 3 za zvuk
        Slot.counter = 0;
        getRandomPositionForAnimalPlace();
        if (LearnNextColorsForThirdGame.activeColor == numberOfColors)
        {
            LearnNextColorsForThirdGame.activeColor = 0;
        }

        // Randomize the list
        activeColors = Fisher_Yates_CardDeck_Shuffle(activeColors);

        string colorToShow = activeColors[LearnNextColorsForThirdGame.activeColor++];
        colorToHide1 = colorToShow;
        showColor();
        if (LearnNextColorsForThirdGame.activeColor == numberOfColors)
        {
            LearnNextColorsForThirdGame.activeColor = 0;
        }
        colorToShow = activeColors[LearnNextColorsForThirdGame.activeColor++];
        colorToHide2 = colorToShow;
        showColor1();
        if (LearnNextColorsForThirdGame.activeColor == numberOfColors)
        {
            LearnNextColorsForThirdGame.activeColor = 0;
        }
        colorToShow = activeColors[LearnNextColorsForThirdGame.activeColor];
        colorToHide3 = colorToShow;
        showColor2();
   //     Debug.Log(prvaZivotinja.sprite.name);
   //     Debug.Log(drugaZivotinja.sprite.name);
   //     Debug.Log(trecaZivotinja.sprite.name);

    }

    public void showColor()
    {

        int choice = firstChoice;
        // Physically show a color
        if (colorToHide1.Trim().Equals("crvena"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/crvena");
            if (choice == 1) {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if(choice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if( choice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            
        }

        if (colorToHide1.Trim().Equals("plava"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/plava");

            if (choice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if ( choice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if ( choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            
        }

        if (colorToHide1.Trim().Equals("zelena"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zelena");

            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (choice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (choice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
        }

        if (colorToHide1.Trim().Equals("zuta"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zuta");

            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }

        }

        if (colorToHide1.Trim().Equals("narancasta"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/narancasta");
            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (choice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
        }

        if (colorToHide1.Trim().Equals("ruzicasta"))
        {
            prvaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/ruzicasta");

            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }

        }
    }

    public void showColor1()
    {
       
        int choice = secondChoice;
       
        // Physically show a color
        if (colorToHide2.Trim().Equals("crvena"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/crvena");

            if (choice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if (choice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
        }

        if (colorToHide2.Trim().Equals("plava"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/plava");

            if (choice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if (choice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }

        }

        if (colorToHide2.Trim().Equals("zelena"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zelena");
            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (choice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
        }

        if (colorToHide2.Trim().Equals("zuta"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zuta");
            if (choice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }

        }

        if (colorToHide2.Trim().Equals("narancasta"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/narancasta");
            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (choice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
        }

        if (colorToHide2.Trim().Equals("ruzicasta"))
        {
            drugaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/ruzicasta");
            if (choice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (choice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (choice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }

        }
    }

   
    public void showColor2()
    {
  
        // Physically show a color
        if (colorToHide3.Trim().Equals("crvena"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/crvena");
            if (thirdChoice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if (thirdChoice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
            else if (thirdChoice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/papiga");
            }
        }

        if (colorToHide3.Trim().Equals("plava"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/plava");

            if (thirdChoice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if (thirdChoice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }
            else if (thirdChoice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/riba");
            }

        }

        if (colorToHide3.Trim().Equals("zelena"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zelena");
            if (thirdChoice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (thirdChoice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
            else if (thirdChoice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/zaba");
            }
        }

        if (colorToHide3.Trim().Equals("zuta"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/zuta");
            if (thirdChoice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (thirdChoice == 2 )
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
            else if (thirdChoice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/pile");
            }
        }

        if (colorToHide3.Trim().Equals("narancasta"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/narancasta");
            if (thirdChoice == 1)
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (thirdChoice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
            else if (thirdChoice == 3 )
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/macka");
            }
        }

        if (colorToHide3.Trim().Equals("ruzicasta"))
        {
            trecaBoja.sprite = Resources.Load<Sprite>("Dominantna boja/boje/ruzicasta");
            if (thirdChoice == 1 )
            {
                prvaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (thirdChoice == 2)
            {
                drugaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
            else if (thirdChoice == 3)
            {
                trecaZivotinja.sprite = Resources.Load<Sprite>("Dominantna boja/likovi/svinja");
            }
        }
    }

    public void getRandomPositionForAnimalPlace()
    {
        while (allChoices.Count != 3)
        {
            allChoices.Add(UnityEngine.Random.Range(1, 4));
        }
        int[] stringArray = new int[allChoices.Count];
        allChoices.CopyTo(stringArray);
        firstChoice = stringArray[0];
        secondChoice = stringArray[1];
        thirdChoice = stringArray[2];
        // dodaj 3 elementa u size i odredi first,second,third choice...
    }
    private void getActiveColors()
    {
        if (GameObject.Find("__app").GetComponent<Varijable>().crvena == true)
        {
            activeColors.Add("crvena");
        }

        if (GameObject.Find("__app").GetComponent<Varijable>().plava == true)
        {
            activeColors.Add("plava");
        }

        if (GameObject.Find("__app").GetComponent<Varijable>().zelena == true)
        {
            activeColors.Add("zelena");
        }

        if (GameObject.Find("__app").GetComponent<Varijable>().zuta == true)
        {
            activeColors.Add("zuta");
        }

        if (GameObject.Find("__app").GetComponent<Varijable>().narancasta == true)
        {
            activeColors.Add("narancasta");
        }

        if (GameObject.Find("__app").GetComponent<Varijable>().ruzicasta == true)
        {
            activeColors.Add("ruzicasta");
        }

        numberOfColors = activeColors.Count;
    }

    // Randomize the list
    public static List<string> Fisher_Yates_CardDeck_Shuffle (List<string>aList) {
 
         System.Random _random = new System.Random ();
 
         string myString;
 
         int n = aList.Count;
         for (int i = 0; i < n; i++)
         {
             // NextDouble returns a random number between 0 and 1.
             // ... It is equivalent to Math.random() in Java.
             int r = i + (int)(_random.NextDouble() * (n - i));
             myString = aList[r];
             aList[r] = aList[i];
             aList[i] = myString;
         }
 
         return aList;
    }
}
