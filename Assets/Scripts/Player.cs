using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody rb;
    private Animation thisAnimation;

    void Start()
    {
        rb=GetComponent<Rigidbody>();
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.position.y < 3.52f && transform.position.y > -3.65f)
            {
             rb.velocity = Vector2.up * velocity;
             thisAnimation.Play();
            }
        }
    }
}
