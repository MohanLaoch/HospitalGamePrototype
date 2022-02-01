using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTestDialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool NearNPC = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Receptionist"))
        {
            NearNPC = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NearNPC = false;
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        

        if (NearNPC == true && Input.GetKeyDown("space"))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        }
        if(NearNPC == false)
        {
            FindObjectOfType<DialogueManager>().EndDialogue(dialogue);
        }
    }

    public void DisplayText()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }
}
