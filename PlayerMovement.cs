using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    
    private float axisX;

    public bool facingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        axisX = Input.GetAxisRaw("Horizontal");
        direction = new Vector2(axisX, rb.velocity.y);

        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);

        if (axisX > 0 && !facingRight)
        {
            FlipSprite();
        }
        else if (axisX < 0 && facingRight)
        {
            FlipSprite();
        }
    }

    void FlipSprite()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
