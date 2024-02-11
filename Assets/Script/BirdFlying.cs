using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class BirdFlying : MonoBehaviour
{
    public AudioSource die, point, touch, background;
    public Animator flying;
    public Text Point;
    Animator animator;
    Rigidbody2D rigidBody;
    float speed = 7f;
    int Score = 0;

    void Start()
    {
        
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Point.text = "" + Score;

        background.Play();

    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2(speed, rigidBody.velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            touch.Play();

            rigidBody.velocity = new Vector2(rigidBody.velocity.x, speed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            point.Play();

            Score++;
            Point.text = "" + Score;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "kill")
        {
            die.Play();

            PlayerPrefs.SetInt("Point", Score);

            animator.SetTrigger("isDie");

            PlayerPrefs.SetInt("Point", Score);

            speed = 0f;
            float posY = -4.42f;
            Vector2 Pos = new Vector2(transform.position.x, posY);

            StartCoroutine(Die());

        }
    }
    
    IEnumerator Die()
    {
        yield return new WaitForSeconds(0.2f);

        SceneManager.LoadScene("Looser");
        flying.enabled = false;
    }


}
