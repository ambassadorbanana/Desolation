using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByContact : MonoBehaviour
{
    //astroid
    public GameObject explosion;
    //player
    public GameObject playerExplosion;

    //give hazards a value
    public int scoreValue;

    //make new class for the GC
    private GameController gameController;


    private void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject!= null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if(gameController == null)
        {
            Debug.Log("Cannot find 'Game Controller' script... problem..");
        }
    }

    // Destroy everything that enters the trigger including the astroid children but done at the end of the frame 
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name);  keep it from destorying the boundary tagged items 
        if(other.tag == "boundary")
        {
            return;
        }
        //for the astroid explosion
        Instantiate(explosion, transform.position, transform.rotation);

        //for the player colliading with astroid
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            //call gameover function
            gameController.GameOver();
            
        }
        //one in the variable established above; each hazz has to find an instance of this full script 
        gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
