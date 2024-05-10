using System;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    // Look 을 실행할 클래스

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;
    private EventHub hub;

    private void Awake()
    {
        hub = GetComponent<EventHub>();
    }

    private void Start()
    {
        hub.OnLookEvent += Look;

    }


    private void Look(Vector2 direction)
    {
        LookObject(direction);
    }

    private void LookObject(Vector2 direction)
    {
        // 플레이어 - 마우스 의 각도를 얻는다.
        float degreeObjToMouse = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = (Mathf.Abs(degreeObjToMouse) > 90f);

        armPivot.rotation = Quaternion.Euler(0, 0, degreeObjToMouse);

    }
}

