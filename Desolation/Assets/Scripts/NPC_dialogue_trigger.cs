using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NPC_dialogue_trigger : MonoBehaviour {

    public Dialogue dialogue;
    public void TriggerDialogue()
    {
        //find dialogue mangager and tell which convo to start
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
