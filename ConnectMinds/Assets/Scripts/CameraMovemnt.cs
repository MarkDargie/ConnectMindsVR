using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CameraMovemnt : MonoBehaviour
{
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        camera.stereoTargetEye = StereoTargetEyeMask.None;
        //XRSettings.gameViewRenderMode = GameViewRenderMode.None;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
