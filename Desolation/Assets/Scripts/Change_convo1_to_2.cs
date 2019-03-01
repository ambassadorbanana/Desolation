using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;


public class Change_convo1_to_2: MonoBehaviour
{
    private void Update()
    {
        //Load a scene by the name "SceneName" if you press the C key.  loads conversation 2 with Nantoka 
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("convo_ex2");

        }

    }



}
