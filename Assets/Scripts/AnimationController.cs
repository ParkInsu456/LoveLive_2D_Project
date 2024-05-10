using System;
using UnityEngine;

public class AnimationController : AnimatorController
{
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");


    protected override void Awake()
    {
        base.Awake();
    }


    private void Start()
    {
        eventhub.OnDirectionEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(IsWalk, true);
    }
}