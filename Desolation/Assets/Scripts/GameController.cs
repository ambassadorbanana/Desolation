using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add this to get the UI class for text etc. 
using UnityEngine.UI;
//add new info for the scene management info
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

//spwan hazards in the game 
public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    
    //score
    public Text scoreText;
    private int score;
    //text 
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;


    //calls these functions at start of the game 1st frame
    private void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    private void Update()
    {
        //shorthand for if restart is true
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //here is where we can have the next level loaded too 
                //Application.LoadLevel(Application.loadedLevel);
                SceneManager.LoadScene("main");
            }
            else if (Input.GetKeyDown(KeyCode.T))
            {
                SceneManager.LoadScene("demo_thouse");

            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                SceneManager.LoadScene("second_fight");
            }
            else if (Input.GetKeyDown(KeyCode.G))
                {
                SceneManager.LoadScene("second_fight");
            }

        }
    }


    //create function to control waves 
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {


            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);

            }
            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                restartText.text = "Press 'R' to Restart Your Mission";
                restart = true;
                //get out of the while loop
                break;
            }

        }
    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    //update the score info and text; if the player gets 1000 zenni (make sur ethis is for the main scene)they move on to the asano warning takeove scene
    void UpdateScore()
    {
        scoreText.text = "Zenni Earned: " + score;
        if(score == 500)
        {
            SceneManager.LoadScene("the_takeover");
        }
    }

    //call the game over
    public void GameOver()
    {

        gameOverText.text = "Game Over!";
        gameOver = true;

    }



}
