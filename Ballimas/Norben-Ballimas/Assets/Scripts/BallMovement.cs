using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    float horizontalMove = 0.0f;
    public float speed;
    public float bounceBack;

    private Rigidbody2D rb;

    public bool onGround = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMove * speed, Mathf.Clamp(rb.velocity.y, -speed, speed));
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Floor")
        {
            onGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Block")
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y + bounceBack);
        }
    }

    void FixedUpdate()
    {

    }
}
