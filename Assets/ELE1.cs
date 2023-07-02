using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ELE1 : MonoBehaviour
{
    public GameObject fish;
    public VirtualButtonBehaviour green;

    void Start()
    {
        green.RegisterOnButtonPressed(OnButtonPressed1);
        fish.SetActive(false);
        
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        fish.SetActive(true);   
    }


}
