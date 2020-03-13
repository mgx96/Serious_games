using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;

    private CharacterController charContrller;

    bool breakdown;

    private void Awake()
    {
        charContrller = GetComponent<CharacterController>();
        breakdown = false;
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;
        float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charContrller.SimpleMove(forwardMovement + rightMovement);
    }

    public void setBreakdown(bool value)
    {
        breakdown = value;
    }

    public bool getBreakdown()
    {
        return breakdown;
    }
}
