using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HeadBobbing : MonoBehaviour
{
    [Header("Transform references")]
    public Transform headTransform;
    public Transform cameraTransform;

    [Header("Head bobbing")]
    public float bobFrequency = 5f;
    public float bobHorizontalAmplitude = 0.1f;
    public float bobVerticalAmplitude = 0.1f;
    [Range(0, 1)] public float headBobSmoothing = 0.1f;


    // State
    public bool isWalking;
    private float walkingTime;
    private Vector3 targetCameraPosition;


    // Update is called once per frame
    private void Update()
    {
        //Set time and offset to 0
        if (!isWalking) walkingTime = 0;
        else walkingTime += Time.deltaTime;

        // Calculate the camera's target pos
        targetCameraPosition = headTransform.position + CalculateHeadBobOffset(walkingTime);

        // Interpolate pos
        cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetCameraPosition, headBobSmoothing);
        // Snap to pos if it is close enough
        if ((cameraTransform.position - targetCameraPosition).magnitude <= 0.001) cameraTransform.position = targetCameraPosition;
    }

    private Vector3 CalculateHeadBobOffset(float t)
    {
        float horizontalOffset = 0;
        float verticalOffset = 0;
        Vector3 offset = Vector3.zero;

        if (t > 0)
        {
            // Calculate offsets
            horizontalOffset = Mathf.Cos(t * bobFrequency) * bobHorizontalAmplitude;
            verticalOffset = Mathf.Sin(t * bobFrequency * 2) * bobVerticalAmplitude;

            offset = headTransform.right * horizontalOffset + headTransform.up * verticalOffset;
        }
        return offset;
    }
}
