
using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviorSendMessage : MonoBehaviour
{
    private void OnMovement(InputValue inputValue)
    {
        Debug.Log("WASD, ����Ű�� �����ϸ� ����");
    }

    private void OnAiming(InputValue inputValue)
    {
        Debug.Log("���콺�� �̵��ϸ� ����");
    }

    private void OnMouseActivity(InputValue inputValue)
    {
        Debug.Log("���콺 ��Ŭ�� ��Ŭ�� Pressed, Released");
    }
}