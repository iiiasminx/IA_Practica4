using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AUDIOS2 : MonoBehaviour
{
    public AudioSource audioData1;
    public VirtualButtonBehaviour green;

    public GameObject fish;
        public GameObject robot;
        public GameObject mushroom;


    // Start is called before the first frame update
    void Start()
    {
        green.RegisterOnButtonPressed(OnButtonPressed1);
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);
        audioData1.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
}
