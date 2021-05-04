using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{

    public bool showController = false;
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;

    public GameObject handModelPrefab;

    private InputDevice targetDevice;
    private GameObject spawnedController;
    private GameObject spawnedHandModel;

    // Start is called before the first frame update
    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if(devices.Count > 0)
        {
            targetDevice = devices[0];
            Debug.Log("TARGET DEVICE: " + targetDevice.name + targetDevice.characteristics);

            GameObject prefab = controllerPrefabs.Find(controller => controller.name == targetDevice.name);
            if (prefab)
            {
                //spawnedController = Instantiate(prefab, transform);
            }
            else
            {
                Debug.Log("Could Not Find corresponding controller model");
                //spawnedController = Instantiate(controllerPrefabs[0], transform);
            }

            spawnedHandModel = Instantiate(handModelPrefab, transform);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (showController)
        {
            spawnedHandModel.SetActive(false);
            spawnedController.SetActive(true);
        }
        else
        {
            spawnedHandModel.SetActive(true);
            spawnedController.SetActive(false);
        }

        targetdevice.trygetfeaturevalue(commonusages.primarybutton, out bool primarybuttonvalue);
        if (primarybuttonvalue)
        {
            debug.log("pressing primary button");
        }

        targetdevice.trygetfeaturevalue(commonusages.trigger, out float triggervalue);
        if (triggervalue > 0.1f)
        {
            debug.log("trigger pressed " + triggervalue);
        }

        targetdevice.trygetfeaturevalue(commonusages.primary2daxis, out vector2 primary2daxisvalue);
        if (primary2daxisvalue != vector2.zero)
        {
            debug.log("primary touchpad" + primary2daxisvalue);
        }
    }
}
