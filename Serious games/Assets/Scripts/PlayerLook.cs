using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;
    [SerializeField] private Transform playerBody;
    private float xAxisClamp;
    bool locked;
    private void Awake()
    {
        LockCursor();

        xAxisClamp = 0.0f;
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        locked = true;
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        locked = false;
        Cursor.visible = true;
    }

    private void Update()
    {
        if (locked)
        {
            CameraRotation();
        }


    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if(xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;

            ClampAxisRotationToValue(270.0f);
        }

        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;

            ClampAxisRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
                eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
