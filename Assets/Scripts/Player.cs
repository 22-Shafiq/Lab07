using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    public GameManager gm;
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
            if(transform.position.y < 3.40f)
            {
             rb.velocity = Vector2.up * velocity;
             thisAnimation.Play();
            }
        }
        else if(transform.position.y < -4.46)
        {
            gm.GameOver();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Obstacle")
        {
            gm.GameOver();
        }
    }
}
