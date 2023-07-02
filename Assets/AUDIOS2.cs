using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AUDIOS2 : MonoBehaviour
{
    public AudioSource audioData1;
    public VirtualButtonBehaviour green;
    // Start is called before the first frame update
    void Start()
    {
        green.RegisterOnButtonPressed(OnButtonPressed1);
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        audioData1.Play();
        Debug.Log("OPRIMISTE UN BOTOOON 1");
    }
}
