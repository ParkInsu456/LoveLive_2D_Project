

using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : EventHub
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    // InputSystem을 통해 입력을 받으면 입력신호를 매개변수로 CallDirectionEvent 이벤트호출
    public void OnMove(InputValue value) // UnityEngine.InputSystem의 입력을 매개변수로 사용한다.
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // InputSystem의 입력정보에서 Vector2정보를 얻는다. 그것을 moveInput에 캐싱. // normalized는 UnityEngine에서 지원하는 기능.
        CallDirectionEvent(moveInput);
    }

    // 
    public void OnLook(InputValue value)
    {
        Vector2 mouseInputValue = value.Get<Vector2>();
        Vector2 mouseWorldPos = _camera.ScreenToWorldPoint(mouseInputValue);
        Vector2 mouseDirection = (mouseWorldPos - (Vector2)transform.position).normalized;

        CallLookEvent(mouseDirection);
    }
}