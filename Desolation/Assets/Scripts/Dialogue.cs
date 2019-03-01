using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


//have to serialize this for the inspector 
[System.Serializable]

public class Dialogue{
    //gives the NPC's name and takes in sentences/dialogue
    public string name;

    //set min and max for text area lines
    [TextArea(3, 10)]
    public string[] sentences;
}
