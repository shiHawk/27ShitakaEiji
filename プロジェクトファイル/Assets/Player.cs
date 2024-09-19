using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D Rigidbody2D;
    Animator animator;
    float jumpForce = 280.0f;
    int jumpCounter = 0;
    float walkForce = 0.72f;
    float maxwalkSpeed = 10.5f;
    public  int Score = 0;
    public  int GetScore()
    {  return Score; }
    // Start is called before the first frame update
    void Start()
    {
        this.Rigidbody2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(-0.006f, 0, 0);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(0.006f, 0, 0);
        //}

        int key = 0;
        if (Input.GetKey(KeyCode.D)) key = 1;
        
        if (Input.GetKey(KeyCode.A)) key = -1;

        float speedx = Mathf.Abs(this.Rigidbody2D.velocity.x);

        if (speedx < this.maxwalkSpeed)
        {
            this.Rigidbody2D.AddForce(transform.right * key * this.walkForce *15);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3 (key,1,1);
        }

        if (jumpCounter <= 1)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                this.animator.SetTrigger("JumpTrigger");
                 this.Rigidbody2D.AddForce(transform.up * this.jumpForce);
                jumpCounter++;
            }
        }

        if(this.Rigidbody2D.velocity.y == 0)
        {
            this.animator.speed = speedx / 2.0f;
        }
        else
        {
            this.animator.speed = 1.0f;
        }

        if(transform.position.y < -5.57f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
        this.animator.speed = speedx / 2.0f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            jumpCounter = 0;
        }
        if (collision.gameObject.tag == "Monster")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // コインに触れたらスコア加算
        if (collision.gameObject.tag == "Coin")
        {
            Score += 10;
            GetComponent<AudioSource>().Play();
        }
    }
}
