using System.Collections;
using System.Collections.Generic;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;

using UnityEngine;

public class ChangeScene : MonoBehaviour {

    public string scenename;

    public void advanceScene()
    {
        if(scenename != "")
        {

            if(GameObject.FindObjectOfType<SceneFader>() != null)
            {
                //starts the fade in and loads the enxt scene called scenename
                StartCoroutine(GameObject.FindObjectOfType<SceneFader>().FadeAndLoadScene(SceneFader.FadeDirection.In, scenename));
                Debug.Log("Scene changed to "+ scenename);
                //SceneManager.LoadScene("opening");
            }
            else
            {
                Debug.LogError("No screen fader object found");
            }

        }
        else
        {
            Debug.LogError("Scene name is empty");
        }


    }
}
