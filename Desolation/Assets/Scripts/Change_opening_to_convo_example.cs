using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;


public class Change_opening_to_convo_example : MonoBehaviour
{
    private void Update()
    {
        //Load a scene by the name "SceneName" if you press the C key.  loads the first convo example after the opening 
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("convo example");

        }

    }



}
