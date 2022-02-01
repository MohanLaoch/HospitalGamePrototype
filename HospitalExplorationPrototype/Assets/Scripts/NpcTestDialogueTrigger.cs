using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTestDialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool NearNPC = false;
    public GameObject dialogueBox;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NearNPC = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NearNPC = false;
    }
    private void Start()
    {
        dialogueBox.SetActive(false);
    }
    private void Update()
    {
        if (NearNPC == true && Input.GetKeyDown("space"))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            gameObject.SetActive(true);
        }
        if(NearNPC == false)
        {
            FindObjectOfType<DialogueManager>().EndDialogue(dialogue);
        }
    }
}
