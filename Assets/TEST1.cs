using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TEST1 : MonoBehaviour
{

    public GameObject cube;
    public VirtualButtonBehaviour Vb1;

    void Start()
    {
        Vb1.RegisterOnButtonPressed(OnButtonPressed1);
    }

    public void OnButtonPressed1(VirtualButtonBehaviour vb){
        var cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.magenta);     
    }

}
