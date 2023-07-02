using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class START1 : MonoBehaviour
{
    public GameObject fish;
    public GameObject robot;
    public GameObject mushroom;
    public GameObject pan;
    public GameObject hsark;

    public VirtualButtonBehaviour green;
    public VirtualButtonBehaviour black;
    public VirtualButtonBehaviour orange;
    public VirtualButtonBehaviour yellow;
    public VirtualButtonBehaviour blue;


    void Start()
    {
        var cubeRenderer = fish.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta); 
        cubeRenderer = robot.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta); 
        cubeRenderer = mushroom.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta); 
        cubeRenderer = pan.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta); 
        cubeRenderer = hsark.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta); 

        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);
        pan.SetActive(false);
        hsark.SetActive(false);

        Debug.Log("INICIANDO");

        green.RegisterOnButtonPressed(OnButtonPressed1);
        black.RegisterOnButtonPressed(OnButtonPressed2);
        orange.RegisterOnButtonPressed(OnButtonPressed3);
        yellow.RegisterOnButtonPressed(OnButtonPressed4);
        blue.RegisterOnButtonPressed(OnButtonPressed5);
        
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        robot.SetActive(false);
        mushroom.SetActive(false);
        pan.SetActive(false);
        hsark.SetActive(false);

        fish.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
    public void OnButtonPressed2(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        mushroom.SetActive(false);
        pan.SetActive(false);
        hsark.SetActive(false);

        
        robot.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 2");
    }

    public void OnButtonPressed3(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        robot.SetActive(false);
        pan.SetActive(false);
        hsark.SetActive(false);

        
        mushroom.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 3");
    }

    public void OnButtonPressed4(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);
        hsark.SetActive(false);

        
        pan.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 4");
    }

    public void OnButtonPressed5(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);
        pan.SetActive(false);
       
        hsark.SetActive(true);
        Debug.Log("OPRIMISTE UN BOTOOON 5");
    }


}
