using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivate : MonoBehaviour
{

    public Camera camera;
    public int display = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Display.displays.Length; i++)
        {
            camera.targetDisplay = display;
            Display.displays[i].Activate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(camera.name + camera.targetDisplay.ToString());
    }
}
