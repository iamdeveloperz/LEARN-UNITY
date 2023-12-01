
using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviorSendMessage : MonoBehaviour
{
    private void OnMovement(InputValue inputValue)
    {
        Debug.Log("WASD, 방향키로 조작하면 동작");
    }

    private void OnAiming(InputValue inputValue)
    {
        Debug.Log("마우스가 이동하면 동작");
    }

    private void OnMouseActivity(InputValue inputValue)
    {
        Debug.Log("마우스 좌클릭 우클릭 Pressed, Released");
    }
}