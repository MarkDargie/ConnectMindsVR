using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class VRMap
{
    public Transform vrTarget;
    public Transform rigTarget;
    public Vector3 trackingPosOffset;
    public Vector3 trackingRotOffset;

    public void Map()
    {
        rigTarget.position = vrTarget.TransformPoint(trackingPosOffset);
        rigTarget.rotation = vrTarget.rotation * Quaternion.Euler(trackingRotOffset);
    }
}

public class VRRig : MonoBehaviour
{

    // Variables for VR Headset Objects
    public VRMap head;
    public VRMap leftHand;
    public VRMap rightHand;

    // Variables for Rig Constraints
    public Transform headContraint;
    public Transform PositionSet;
    public Vector3 headBodyOffset;

    // Variables for set VR Positioning 
    public GameObject headsetPosition;
    public Camera headsetCamera;


    // Start is called before the first frame update
    void Start()
    {
        headBodyOffset = transform.position - headContraint.position;

        headsetCamera.transform.position = headsetPosition.transform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = PositionSet.position + headBodyOffset;
        //transform.position = headContraint.position + headBodyOffset;
        //transform.forward = Vector3.ProjectOnPlane(headContraint.up, Vector3.up).normalized;

        head.Map();
        //leftHand.Map();
        //rightHand.Map();

    }
}
