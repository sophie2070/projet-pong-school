using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float MoveSpeed = 4f;
    public int playerNumber;
    void Update()
    {
        if (playerNumber == 1)
        {
            transform.Translate(Vector2.up * Input.GetAxis("Player1") * MoveSpeed * Time.deltaTime);
        }

        else if (playerNumber == 2)
        {
            transform.Translate(Vector2.up * Input.GetAxis("Player2") * MoveSpeed * Time.deltaTime);
        }
    }
}
