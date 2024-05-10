using System;
using UnityEngine;

public class AnimationController : BasicAnimationController
{
    private static readonly int isWalk = Animator.StringToHash("isWalk");

    private readonly float magnituteThreshold = 0.5f;
    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        eventhub.OnDirectionEvent += Move;  // 움직이면 이벤트가 실행되고 Setbool이 같이 작동한다.
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalk, vector.magnitude > magnituteThreshold);
    }
}