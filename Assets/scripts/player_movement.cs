using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalmove = 0f;
    float runSpeed = 100f;
    bool jump = false;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //animator = GameObject.Find("player1.2").GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {

        horizontalmove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalmove));
          //Debug.Log(animator.GetFloat("Speed"));

        if (Input.GetButtonDown("Jump")) 
        {
            jump = true;
            animator.SetBool("jump",true);
            //Debug.Log(animator.GetBool("jump"));
        }


    }

    public void onLanding()
    {
        animator.SetBool("jump", false);
    }

    //called fixed amount of times per second
    private void FixedUpdate()
    {
        //move character
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump);
        jump = false;
        
    }
}
