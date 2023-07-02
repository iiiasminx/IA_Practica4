using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AUDIOS : MonoBehaviour
{
    public AudioSource audioData1;
    public AudioSource audioData2;
    public AudioSource audioData3;

    public VirtualButtonBehaviour green;
    public VirtualButtonBehaviour black;
    public VirtualButtonBehaviour orange;
    // Start is called before the first frame update
    void Start()
    {
        green.RegisterOnButtonPressed(OnButtonPressed1);
        black.RegisterOnButtonPressed(OnButtonPressed2);
        orange.RegisterOnButtonPressed(OnButtonPressed3);
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        audioData2.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
    public void OnButtonPressed2(VirtualButtonBehaviour vb){
        audioData1.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 2");
    }

    public void OnButtonPressed3(VirtualButtonBehaviour vb){
        audioData3.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 3");
    }

}
