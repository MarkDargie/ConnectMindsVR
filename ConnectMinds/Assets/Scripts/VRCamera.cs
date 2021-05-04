using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRCamera : MonoBehaviour
{

    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        camera.stereoTargetEye = StereoTargetEyeMask.Both;
        //XRSettings.gameViewRenderMode = GameViewRenderMode.None;
        //XRSettings.gameViewRenderMode = GameViewRenderMode.BothEyes;
        //Camera.main.stereoTargetEye = StereoTargetEyeMask.Both;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
