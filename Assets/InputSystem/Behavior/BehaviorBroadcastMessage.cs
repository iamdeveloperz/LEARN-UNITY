
using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviorBroadcastMessage : MonoBehaviour
{
    private void OnMovement(InputValue inputValue)
    {
        Debug.Log("���� �ڽĿ� �����ϴ� Movement");
    }

    private void OnAiming(InputValue inputValue)
    {
        Debug.Log("�ڽĿ� �����ϴ� Aiming");
    }

    private void OnMouseActivity(InputValue inputValue)
    {
        Debug.Log("�ڽĿ� �����ϴ� MouseActivity Pressed, Released");
    }
}