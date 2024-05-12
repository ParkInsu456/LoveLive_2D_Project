using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
    // Event를 핸들링 할 클래스

    public event Action<Vector2> OnDirectionEvent;
    public event Action<Vector2> OnLookEvent;
    //public event Action OnTextEvent;



    public void CallDirectionEvent(Vector2 direction)
    {
        OnDirectionEvent?.Invoke(direction);
    }

    public void CallLookEvent( Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }


}
