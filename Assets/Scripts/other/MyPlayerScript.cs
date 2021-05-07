using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerScript : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetTrigger("playerChop");
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetTrigger("playerHit");
        }
    }
}