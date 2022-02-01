using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePlayerTrigger : MonoBehaviour
{
    
    public GameObject Receptionist1;
    public GameObject Receptionist2;
    public GameObject Receptionist3;
    public GameObject Receptionist4;
    public GameObject Receptionist5;

    public GameObject StatsNurseIndicator;
    public GameObject BloodsNurseIndicator;
    public GameObject ChefIndicator;
    public GameObject XRayNurseIndicator;
    public GameObject DoctorIndicator;

    public GameObject ReceptionistTextBox;
    
    public int spoken = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Receptionist") && spoken ==0)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 1;
            StatsNurseIndicator.SetActive(true);
            ReceptionistTextBox.SetActive(false);
        }

        if (other.gameObject.CompareTag("StatsNurse") && spoken == 1)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 2;
            Receptionist1.SetActive(false);
            Receptionist2.SetActive(true);
            StatsNurseIndicator.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Receptionist") && spoken == 2)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 3;
            BloodsNurseIndicator.SetActive(true);

        }

        if(other.gameObject.CompareTag("BloodsNurse") && spoken == 3)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 4;
            Receptionist2.SetActive(false);
            Receptionist3.SetActive(true);
            BloodsNurseIndicator.SetActive(false);
            
        }
        
        if (other.gameObject.CompareTag("Receptionist") && spoken == 4)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 5;
            ChefIndicator.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("Chef") && spoken == 5)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 6;
            Receptionist3.SetActive(false);
            Receptionist4.SetActive(true);
            ChefIndicator.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Receptionist") && spoken == 6)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 7;
            XRayNurseIndicator.SetActive(true);
        }
        
        if (other.gameObject.CompareTag("X-RayNurse") && spoken == 7)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 8;
            Receptionist4.SetActive(false);
            Receptionist5.SetActive(true);
            XRayNurseIndicator.SetActive(false);
        }
        
        if (other.gameObject.CompareTag("Receptionist") && spoken == 8)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            spoken = 9;
            DoctorIndicator.SetActive(true);
        }

        if (other.gameObject.CompareTag("Doctor") && spoken == 9)
        {
            other.GetComponent<NpcTestDialogueTrigger>().DisplayText();
            DoctorIndicator.SetActive(false);
        }

  
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
       
    }
}
