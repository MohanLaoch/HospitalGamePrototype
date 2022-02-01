using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlayerTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Receptionist"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
        }

        if(other.gameObject.CompareTag("StatsNurse"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
        }

        if(other.gameObject.CompareTag("BloodsNurse"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }
}
