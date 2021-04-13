using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    public string parametrBoolean1;
    public string parametrBoolean2;
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    bool b = false;

    private void onTriggerEnter(Collider other)
    {
        Debug.Log("Enter the trigger");
        b = !b;
        animator1.SetBool(parametrBoolean1, b);
        animator2.SetBool(parametrBoolean2, b);
        changeVisability();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            b = !b;
            animator1.SetBool(parametrBoolean1, b);
            animator2.SetBool(parametrBoolean2, b);
            changeVisability();
        }

    }

    void changeVisability()
    {
        if (b)
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(false);
            gameObject3.SetActive(true);
        }
        else
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(true);
            gameObject3.SetActive(false);
        }
    }
}
