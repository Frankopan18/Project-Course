using System.Collections.Generic;
using UnityEngine;

namespace Assets.Custom.Scripts
{
    public class MenuActions : MonoBehaviour {


        public void GoToScene(string sceneName)
        {
            #pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(sceneName);
            #pragma warning restore CS0618 // Type or member is obsolete
        }
        
        public void GoToSceneWithCheck(string sceneName)
        {

            List<string> activeColors = new List<string>();
            // Check which colors are active
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

            if (activeColors.Count < 4)
            {

                #pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel("PocetnaPopUp");
                #pragma warning restore CS0618 // Type or member is obsolete


            }
            else
            {
                #pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(sceneName);
                #pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        public void ExitApp()
        {
            Application.Quit();
        }
    }
}
