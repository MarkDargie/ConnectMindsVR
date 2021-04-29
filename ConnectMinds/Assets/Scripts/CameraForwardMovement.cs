using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForwardMovement : MonoBehaviour
{

    public float moveSpeed = 1f;
    private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //camera.stereoTargetEye = StereoTargetEyeMask.None;
        camera = GetComponent<Camera>();
        camera.stereoTargetEye = StereoTargetEyeMask.None;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    //private void FixedUpdate()
    //{
    //    transform.Translate(Vector3.forward * moveSpeed * Time.fixedDeltaTime);
    //}
}
