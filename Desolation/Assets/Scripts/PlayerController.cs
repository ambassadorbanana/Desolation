using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make new class for game boundaries and make the mixas/maxes value visible  in the inspector 
[System.Serializable]
    public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

//making component (script) that can go on a game object and allows built-in methods to be called 
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float tilt;
    //defining boundary variable in this class
    public Boundary boundary;

    public GameObject shot;

    //declares transform type
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    //excecute this code before every frame 
    private void Update()
    {
        //fire with button press; instantiates the thing as a gameobject to return reference to specific object 
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            //get position and rotation from the gameobject's transform --position is vector 3 and raotion is the quaturn/euler info 
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            //audio sound for weapon 
            gameObject.GetComponent<AudioSource>().Play();
        }

    }

        //fixedupdate is engine calling this function to be called once per frame 
     private void FixedUpdate()
        {
            //called before each physics step to get player inputs for movement along X/Y
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            //vector math etc.gets velocity etc. and saves as movement variable
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            //didn't assign speed in the scirpt so I can change it later 
            //updated code before for getting this info from rigidbody
            //update speed 
            gameObject.GetComponent<Rigidbody>().velocity = movement * speed;

            //create boundaries for the player's ship in space along XYZ
            //Y will be 0 to keep player from falling through
            //start at origin 
            gameObject.GetComponent<Rigidbody>().position = new Vector3
               (
                Mathf.Clamp(gameObject.GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp(gameObject.GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax)
                );
            //get tilt info for left/right velocity, the negative makes sure it rotates correctly  
            gameObject.GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, gameObject.GetComponent<Rigidbody>().velocity.x * -tilt);


        }
    
}