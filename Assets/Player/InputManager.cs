using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    PlayerControls controls;
    PlayerControls.GroundMovementActions groundMovement;
     

    Vector2 horizontalInput;
    void awake()
    {
        controls = new PlayerControls();
        groundMovement = controls.GroundMovement;

        groundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
    }

   private void Update()
   {
       movement.ReceiveInput(horizontalInput);
   }

    // Update is called once per frame
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }
}
