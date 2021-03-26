using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    public Animator animator;
    public string parametrBoolean;
    bool b = false;

    private void onTriggerEnter(Collider other)
    {
        Debug.Log("Enter the trigger");
        b = !b;
        animator.SetBool(parametrBoolean, b);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            b = !b;
            animator.SetBool(parametrBoolean, b);
        }
    }
}
