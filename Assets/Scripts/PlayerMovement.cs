using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float MoveSpeed = 4f;
    public int playerNumber;
    void Update()
    {
        /*float horzontalinput = Input.GetAxis("Horizontal");
        float vericalinput = Input.GetAxis("Vertical");
        */

        

        if (playerNumber == 1)
        {
            transform.Translate(Vector2.up * Input.GetAxis("Player1") * MoveSpeed * Time.deltaTime);
            /*if (Input.GetKey(KeyCode.W)) {
                 transform.Translate(Vector2.up * MoveSpeed *  Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
            }*/
        }

        else if (playerNumber == 2)
        {
            transform.Translate(Vector2.up * Input.GetAxis("Player2") * MoveSpeed * Time.deltaTime);

            /*if (Input.GetKey(KeyCode.O))
            {
                transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
            }*/
        }


    }
}
