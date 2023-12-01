
using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviorBroadcastMessage : MonoBehaviour
{
    private void OnMovement(InputValue inputValue)
    {
        Debug.Log("나는 자식에 존재하는 Movement");
    }

    private void OnAiming(InputValue inputValue)
    {
        Debug.Log("자식에 존재하는 Aiming");
    }

    private void OnMouseActivity(InputValue inputValue)
    {
        Debug.Log("자식에 존재하는 MouseActivity Pressed, Released");
    }
}