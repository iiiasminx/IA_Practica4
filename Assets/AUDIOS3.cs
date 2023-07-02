using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AUDIOS3 : MonoBehaviour
{

    public AudioSource audioData1;
    public VirtualButtonBehaviour green;

    public GameObject fish;
        public GameObject robot;
        public GameObject mushroom;
        public GameObject hsark;

    // Start is called before the first frame update
    void Start()
    {
        green.RegisterOnButtonPressed(OnButtonPressed1);
    }

    // Update is called once per frame
    void OnButtonPressed1(VirtualButtonBehaviour green)
    {
        fish.SetActive(false);
        robot.SetActive(false);
        mushroom.SetActive(false);
        hsark.SetActive(false);
        audioData1.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
}
