using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] Camera camera_3d;
    [SerializeField] Camera camera_2d;

    [SerializeField] bool isCamSwithced = false;

    [SerializeField] Transform playerPos;

    private void Start()
    {
        camera_3d.enabled = false;
    }
    void SwitchCams()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && !isCamSwithced)
        {
            Debug.Log("Camera switched");
            camera_3d.enabled = true;
            camera_2d.enabled = false;

            isCamSwithced = true;
        }

        else if(Input.GetKeyDown(KeyCode.Tab) && isCamSwithced)
        {
            camera_3d.enabled = false;
            camera_2d.enabled = true;

            isCamSwithced = false;
        }
    }

    private void Update()
    {
        SwitchCams();
    }
}
