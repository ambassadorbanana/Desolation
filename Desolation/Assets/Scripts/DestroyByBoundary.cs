using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//box boundary is a trigger for destroying things 
public class DestroyByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
    
}
