using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] Camera main_camera, front_camera;
    void Start()
    {
        Display.displays[0].Activate();
        Display.displays[1].Activate();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
