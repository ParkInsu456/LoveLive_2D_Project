using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // 이벤트 액션 인스턴스에 direction으로 움직일 Move함수를 체인하고 FixedUpdate로 Move를 구현할 클래스

    private EventHub hub;
    private Rigidbody2D movementRigidbody2D;

    private Vector2 movementDirection = Vector2.zero;   // 비워두면 오류가 날 수 있어서 zero를 집어넣음. 입력없으면 zero인것도 상정

    private void Awake()
    {
        hub = GetComponent<EventHub>(); // 같은 게임오브젝트의 EventHub를 hub에 가져온다.
        movementRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        hub.OnDirectionEvent += GetDirection;
    }



    private void GetDirection(Vector2 direction)
    {
        movementDirection = direction;
    }


    private void FixedUpdate()
    {
        // movementDirection으로 움직임
        MoveObject(movementDirection);
    }

    private void MoveObject(Vector2 direction)
    {
        direction = direction * 5f; // * speed;  // 기본벡터에 스피드만큼 곱해준다. 증폭한다.
        // 이동은 움직일 대상의 RigidBody2D 물리를 움직인다.
        movementRigidbody2D.velocity = direction;
    }
}