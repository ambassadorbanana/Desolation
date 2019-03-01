using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{

    //object will destroy itself 
    public float lifetime;
    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

}
