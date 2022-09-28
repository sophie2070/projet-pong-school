using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber;
    void Update()
    {
        float horzontalinput = Input.GetAxis("Horizontal");
        float vericalinput = Input.GetAxis("Vertical");

        if (playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.W)) {
                 transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * Time.deltaTime);
            }
            //transform.Translate(new Vector3(0, Input.GetAxis("Player1") * Time.deltaTime, 0));
        }

        else if (playerNumber == 2)
        {
            if (Input.GetKey(KeyCode.O))
            {
                transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.Translate(Vector2.down * Time.deltaTime);
            }
            // transform.Translate(new Vector3(0, Input.GetAxis("Player2") * Time.deltaTime, 0));
        }


    }
}
