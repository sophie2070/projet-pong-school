using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float MoveSpeed = 7f;
    public Vector2 direction = new Vector2(1, 1);

    void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (direction.x > -0.1f && direction.x < 0.1f)
        {
            direction = new Vector2(0.5f, direction.y);
        }
        direction = direction.normalized;
    }



    void Update()
    {
        transform.Translate(direction * MoveSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision detected");
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle")) 
        {
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBarrier"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().Addp2Score();
        }
        if (collision.gameObject.CompareTag("RightBarrier"))
        {
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().Addp1Score();
        }
    }

    private void ResetBall()
    {
        transform.position = new Vector3(0, 0);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        direction = direction.normalized;
    }
}
