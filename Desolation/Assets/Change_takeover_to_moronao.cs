using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;


public class Change_takeover_to_moronao : MonoBehaviour
{
    private void Update()
    {
        //Load a scene by the name "SceneName" if you press the C key.  loads tutorial battle system called main 
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("moronao_warning");

        }

    }



}
