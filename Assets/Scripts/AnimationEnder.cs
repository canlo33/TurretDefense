using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnder : MonoBehaviour
{
    public Animator animator;

    public void AnimationEnded()
    {
        animator.SetBool("isShooting", false);
    }
}
