using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerC : MonoBehaviour
{
    private PlayerController playerController;

    private void Awake()
    {
        playerController = new PlayerController();
    }

    private void OnEnable()
    {
        playerController.Enable();
    }

    private void OnDisabled()
    {
        playerController.Disable();
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 move = playerController.Land.Move.ReadValue<Vector2>();
        Debug.Log(move);
       // playerController.Land.Jump.ReadValue<float>();
       // if(playerController.Land.Jump.ReadValue<float>() == 1)
       if(playerController.Land.Jump.triggered)
        {
            Debug.Log("Jumped");
        }

    }
}
