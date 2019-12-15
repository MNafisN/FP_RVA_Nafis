using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngineUI;
// using Vuforia;

public class anim2 : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animIdle()
    {
        bool play = anim.GetBool("play");
        anim.SetBool("play", true);
    }

    public void animRun()
    {
        bool playRun = anim.GetBool("play_run");
        anim.SetBool("play_run", true);
    }

    public void animJump()
    {
        bool playJump = anim.GetBool("play_jump");
        anim.SetBool("play_jump", true);
    }

    public void animWalk()
    {
        bool playWalk = anim.GetBool("play_walk");
        anim.SetBool("play_walk", true);
    }

    public void animSprint()
    {
        bool playSprint = anim.GetBool("play_sprint");
        anim.SetBool("play_sprint", true);
    }

    public void animBackwards()
    {
        bool playBackwards = anim.GetBool("play_backwards");
        anim.SetBool("play_backwards", true);
    }

    public void animStop()
    {
        bool play = anim.GetBool("play");
        bool playRun = anim.GetBool("play_run");
        bool playJump = anim.GetBool("play_jump");
        bool playWalk = anim.GetBool("play_walk");
        bool playSprint = anim.GetBool("play_sprint");
        bool playBackwards = anim.GetBool("play_backwards");

        anim.SetBool("play", false);
        anim.SetBool("play_run", false);
        anim.SetBool("play_jump", false);
        anim.SetBool("play_walk", false);
        anim.SetBool("play_sprint", false);
        anim.SetBool("play_backwards", false);
    }
}
