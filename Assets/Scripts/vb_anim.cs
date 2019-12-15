using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject anim_btn;
    // public GameObject anim_btn2;
    public Animator anim1;
    // public Animator anim2;

    // Start is called before the first frame update
    void Start()
    {
        anim_btn = GameObject.Find("anim_btn"); 
        anim_btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        anim1.GetComponent<Animator>();

        // anim_btn2 = GameObject.Find("anim_btn2"); 
        // anim_btn2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        // anim2.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (anim1 != null)
            {
                // anim1.Play("Idle01");
                bool play = anim1.GetBool("play");

                anim1.SetBool("play", true);
            }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (anim1 != null)
            {
                // anim1.Play("none");
                bool play = anim1.GetBool("play");

                anim1.SetBool("play", false);
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
