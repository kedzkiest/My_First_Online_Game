using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public float walkSpeed;
    public float rotateSpeed;
    
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * walkSpeed * Time.deltaTime;
            animator.SetBool("run", true);
        }
        else
        {
            animator.SetBool("run", false);
        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
    }
}
