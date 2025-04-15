using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunner : MonoBehaviour
{
   Animator animator;
    Vector3 velocity= Vector3.zero;
    Vector3 acceleration = Vector3.zero;
    float yBegin;
    void Start()
    {
       animator = GetComponent<Animator>(); 
        yBegin = transform.position.y;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            animator.Play("Jump");
            acceleration = new Vector3(0, -10, 0);
            velocity = new Vector3 (0,10, 0);   
        }

        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        if (transform.position.y < yBegin)
        {
            acceleration = Vector3.zero;
            transform.position = new Vector3(transform.position.x, yBegin, 0);
        }
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;    
    }

}
