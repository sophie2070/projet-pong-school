using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float trajectory = 2f;
    void Start()
    {
        transform.position = transform.position + new Vector3(0 * trajectory * Time.deltaTime, 0 * trajectory *Time.deltaTime);
    }


    void Update()
    {
        if ()
    }
}
