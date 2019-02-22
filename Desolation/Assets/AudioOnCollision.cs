using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnCollision : MonoBehaviour
{
    public AudioClip sound; // Add your Audio Clip Here;
     // This Will Configure the  AudioSource Component; 
     // Make Sure You added AudioSouce to relevant area;
     // I think the error message in Unity will resolve once sound files are imported and linked to the script;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource> ().playOnAwake = false;
        GetComponent<AudioSource> ().clip = sound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter () { //Plays Sound Whenever collision detected
        GetComponent<AudioSource>.Play();
        // Make sure that deathzone has a collider, box, or mesh.. ect..,
        // Make sure to turn "off" collider trigger for your enemies;
        // Make sure That anything that collides into enemy is rigidbody;
    }
}
