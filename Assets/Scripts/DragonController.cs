using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public Animator animator;
    public GameObject dragon;

    bool firstPlay;

    public void StartAnimation()
    {
        if (!firstPlay)
        {
            animator.SetTrigger("StartAnim");
            firstPlay = true;
        }
        else
        {
            animator.speed = 1f;
        }
    }

    public void PauseAnimation()
    {
        animator.speed = 0f;
    }

    private void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartAnimation();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            PauseAnimation();
        }
#endif
    }
}
