using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneAfterTime : MonoBehaviour {
    public float delay;

	// Use this for initialization
	void Start () {
        
            StartCoroutine(LoadLevelAfterDelay(delay));
        }

        IEnumerator LoadLevelAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene("dominantna_boja");
        }

    }

