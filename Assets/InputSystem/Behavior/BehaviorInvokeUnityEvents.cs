
using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviorInvokeUnityEvents : MonoBehaviour
{
    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 inputValue = context.ReadValue<Vector2>();
        if(inputValue != null)
        {
            var moveDirection = new Vector3(inputValue.x, 0f, inputValue.y).normalized;
            Debug.Log($"Unity Events Movement : {moveDirection}");
        }
    }

    public void OnAiming(InputAction.CallbackContext context)
    {
        Vector2 mousePos = context.ReadValue<Vector2>();
        Debug.Log($"Unity Events Aiming : {mousePos}");
    }

    public void OnMouseActivity(InputAction.CallbackContext context)
    {
        if (context.control.name == "leftButton")
        {
            if (context.performed)
                Debug.Log("Left Mouse Button Pressed");
            else if (context.canceled)
                Debug.Log("Left Mouse Button Released");
        }
        else if (context.control.name == "rightButton")
        {
            if (context.performed)
                Debug.Log("Right Mouse Button Pressed");
            else if (context.canceled)
                Debug.Log("Right Mouse Button Released");
        }
    }
}