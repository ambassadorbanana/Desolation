using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed; 
    private void Start()
    {
        //get the speed for the laser as it moves forward , had to use vector3 instead of the transform and add it to the Z-axis 
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1) * speed;
    }

}
