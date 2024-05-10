
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    protected Animator animator;
    protected EventHub eventhub;
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        eventhub = GetComponent<EventHub>();
    }

}
