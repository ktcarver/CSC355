using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnim : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }
    /*
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isRunningLeft", false);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isRunningLeft", true);
            animator.SetBool("isRunning", false);
        }
        else if(!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isRunningLeft", false);
        }
        
        /*
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isRunningLeft", true);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRunningLeft", false)
        }
        
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetTrigger("Jump");
        }
        else if(Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetTrigger("JumpLeft");
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if(Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }

        
    }
    
}
