using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;
    public InputAction playerMovement;

    Vector2 moveDirection = Vector2.zero;
    
    private void OnEnable()
    {
        playerMovement.Enable();
    }

    private void OnDisable()
    {
        playerMovement.Disable();
    }

    void Update()
    {
        moveDirection = playerMovement.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }

}
