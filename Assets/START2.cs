using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class START2 : MonoBehaviour
{
    public GameObject fish;
        public GameObject robot;
        public GameObject mushroom;

        public VirtualButtonBehaviour green;
        public VirtualButtonBehaviour black;
        public VirtualButtonBehaviour orange;


    void Start()
    {
        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);

        Debug.Log("INICIANDO");

        green.RegisterOnButtonPressed(OnButtonPressed1);
        black.RegisterOnButtonPressed(OnButtonPressed2);
        orange.RegisterOnButtonPressed(OnButtonPressed3);
        
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        robot.SetActive(false);
        mushroom.SetActive(false);

        fish.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
    public void OnButtonPressed2(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        mushroom.SetActive(false);

        
        robot.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 2");
    }

    public void OnButtonPressed3(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        robot.SetActive(false);

        
        mushroom.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 3");
    }
}
