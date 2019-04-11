using System.Collections;
using System.Collections.Generic;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;

using UnityEngine;

public class StartGame : MonoBehaviour {

	public void startButton_click()
    {
        //starts the fade in and loads the enxt scene caled "opening"
        StartCoroutine(GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, "opening"));
        Debug.Log("Start button clicked");
        //SceneManager.LoadScene("opening");

    }
}
