using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public Animator[] animators;
    // public GameObject[] dragon;


    bool firstPlay;


    public void StartAnimation()
    {
        if (!firstPlay)
        {
            foreach(Animator anim in animators)
            {
                anim.SetTrigger("StartAnim");
                firstPlay = true;
            }

        }
        else
        {

            foreach(Animator anim in animators)
            {
                anim.speed = 1f;

            }
            // animator.speed = 1f;
        }
    }

    public void PauseAnimation()
    {
        foreach(Animator anim in animators)
        {
            anim.speed = 0f;

        }
        // animator.speed = 0f;
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
