﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform followTransform;

    public float xMin, xMax, yMin, yMax;
    private float camY, camX;
    public float camOrthsize = 2.034264f;
    public float cameraRatio = 4.767132f;
    private Camera mainCam;

    private void Start()
    {
        Cursor.visible = true;
        //variables to change depending of the background
        xMin = -10f;
        xMax = 12f;
        yMin = -9.5f;
        yMax = 1.8f;
        mainCam = GetComponent<Camera>();
        camOrthsize = mainCam.orthographicSize;
        cameraRatio = (xMax + camOrthsize) / 2.0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        camY = Mathf.Clamp(followTransform.position.y, yMin + camOrthsize, yMax - camOrthsize);
        camX = Mathf.Clamp(followTransform.position.x, xMin + cameraRatio, xMax - cameraRatio);
        this.transform.position = new Vector3(camX, camY, this.transform.position.z);


    }
}
