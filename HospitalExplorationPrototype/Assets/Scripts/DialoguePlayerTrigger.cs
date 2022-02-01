using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlayerTrigger : MonoBehaviour
{

    public int spoken = 0;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Receptionist"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 1;
        }

        if(other.gameObject.CompareTag("StatsNurse") && spoken == 1)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 2;
        }

        if (other.gameObject.CompareTag("BloodsNurse"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            
        }

        if (other.gameObject.CompareTag("Doctor"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
        }

        if (other.gameObject.CompareTag("Chef"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            
        }

        if (other.gameObject.CompareTag("X-RayNurse"))
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }
}
