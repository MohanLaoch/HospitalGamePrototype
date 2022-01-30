using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTestDialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool NearNPC = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NearNPC = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NearNPC = false;
    }

    private void Update()
    {
        if (NearNPC == true && Input.GetKeyDown("space"))
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}
