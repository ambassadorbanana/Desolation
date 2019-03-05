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
        Debug.Log("Start button clicked");
        SceneManager.LoadScene("opening");

    }
}
