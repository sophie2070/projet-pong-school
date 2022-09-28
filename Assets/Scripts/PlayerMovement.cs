using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerNumber = 1;
    void Update()
    {
        float horzontalinput = Input.GetAxis("horizontal");
        float vericalinput = Input.GetAxis("vertical");

        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * Time.deltaTime, 0));
        }

        else if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * Time.deltaTime, 0));
        }


    }
}
