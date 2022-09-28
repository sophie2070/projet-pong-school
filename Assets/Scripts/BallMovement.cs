using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float trajectory = 2.0f;
    void Start()
    {
        transform.position = transform.position + new Vector3(0 * trajectory * deltatime, 0 * trajectory * deltatime, 0);
    }

    void Update()
    {
        
    }
}
