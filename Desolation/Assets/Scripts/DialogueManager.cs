using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class DialogueManager : MonoBehaviour {
    //pass in dialogue object (like with DisjoinT)
    public Text nameText;
    public Text dialogueText;

    //checks dialogue box animation 
    public Animator animator;

    //contains text info sentences/phrases whatever as a queue instead of array etc. 
    private Queue<string> sentences;



    private void Start()
    {
        //set up sentence variable
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        //console log the dialogue etc.
        Debug.Log("Starting conversation with " + dialogue.name);
        //sets the open animation to true for the start of a new dialogue 
        animator.SetBool("IsOpen", true); 
        //makes the name and dialogue text set up
        nameText.text = dialogue.name;
        //clear old dialogue 
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }

        //display the sentences
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        //check if more sentences
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        //store other sentences in the queue
        string sentence = sentences.Dequeue();
        //if user tries to click out of the typed message in the current sentence and starts a new setnence
        StopAllCoroutines();
        //dialogueText.text = sentence;
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End of the convo!");
        //sets animator to false 
        animator.SetBool("IsOpen", false);

    }


}
