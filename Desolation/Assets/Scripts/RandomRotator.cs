using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    //hold max tumble value in the editor
    public float tumble;

    //get random velocity for the astroid object -- inside unit sphere for all the vector3 values 
    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
