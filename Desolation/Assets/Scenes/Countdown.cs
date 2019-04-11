using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
//add new info for the scene management info
//using UnityEngine.SceneManagement;
//using UnityEngine.EventSystems;
//for our own records found this info here https://www.noob-programmer.com/unity3d/countdown-timer/

public class Countdown : MonoBehaviour
{

    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object
    //added these booleans to set gameover varibale to true form GamecontrollerB2 script
    private bool gameOver;
    private object gameOverText;
    //uitext 
    //static public GUIText guiText;


    // Use this for initialization
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft); //Showing the Score on the Canvas
    }

    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;

            if (timeLeft == 0)
            {
                //gameOverText.text = "You couldn't escape the graveyard...";
                gameOver = true;
            }

        }



    }
}