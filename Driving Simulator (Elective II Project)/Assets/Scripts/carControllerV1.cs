using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControllerV1 : MonoBehaviour
{
    private const string HORIZONTAL = "horizontal";
    private const string VERTICAL = "Vertical";
    
    private float horizontalInput;
    private float verticalInput;
    private float steerAngle;
    private bool isBreaking;

    public WheelCollider frontLeftWheelCollider;
    public WheelCollider frontRightWheelCollider;
    public WheelCollider rearLeftWheelCollider;
    public WheelCollider rearRightWheelCollider;
    public Transform frontLeftWheelTransform;
    public Transform frontRightWheelTransform;
    public Transform rearLeftWheelTransform;
    public Transform rearRightWheelTransform;

    public float maxSteeringAngle = 30f;
    public float motorForce = 50f;
    public float brakeForce = 0f;
    public float scrollVal;

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();
    }

    private void GetInput()
    {
        horizontalInput = SimpleInput.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleSteering()
    {
        steerAngle = maxSteeringAngle * horizontalInput;
        frontLeftWheelCollider.steerAngle = steerAngle;
        frontRightWheelCollider.steerAngle = steerAngle;
    }

    private void HandleMotor()
    {
        if(GearIndicatorUI.GearSelector==2)
        {
            verticalInput = Mathf.Clamp(verticalInput, 0f, 0.9f);
            rearLeftWheelCollider.motorTorque = (verticalInput+0.1f) * motorForce;
            rearRightWheelCollider.motorTorque = (verticalInput+0.1f) * motorForce;
        }

        else if(GearIndicatorUI.GearSelector==1)
        {
            verticalInput = Mathf.Clamp(verticalInput, 0f, 0f);
            rearLeftWheelCollider.motorTorque = (verticalInput) * motorForce;
            rearRightWheelCollider.motorTorque = (verticalInput) * motorForce;
        }

        else if(GearIndicatorUI.GearSelector==0)
        {
            if(verticalInput >= 0)
            {
                verticalInput = Mathf.Clamp(verticalInput, 0f, 0.9f);
                verticalInput = verticalInput*-1;
                rearLeftWheelCollider.motorTorque = (verticalInput-0.1f) * motorForce;
                rearRightWheelCollider.motorTorque = (verticalInput-0.1f) * motorForce;
            }

        }
        
        Debug.Log(rearRightWheelCollider.motorTorque);

        brakeForce = isBreaking ? 3000f : 0f;
        frontLeftWheelCollider.brakeTorque = brakeForce;
        frontRightWheelCollider.brakeTorque = brakeForce;
        rearLeftWheelCollider.brakeTorque = brakeForce;
        rearRightWheelCollider.brakeTorque = brakeForce;
    }

    private void UpdateWheels()
    {
        UpdateWheelPos(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateWheelPos(frontRightWheelCollider, frontRightWheelTransform);
        UpdateWheelPos(rearLeftWheelCollider, rearLeftWheelTransform);
        UpdateWheelPos(rearRightWheelCollider, rearRightWheelTransform);
    }

    private void UpdateWheelPos(WheelCollider wheelCollider, Transform trans)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        trans.rotation = rot;
        trans.position = pos;
    }

}