using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    private int scoreP1 = 0;
    private int scoreP2 = 0;
    public Text scorePLayer1;
    public Text scorePLayer2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Addp1Score()
    {
        
        {
           scoreP1++;
            scorePLayer1.text = scoreP1.ToString();
           
        }
    }

    public void Addp2Score()
    {
        
        {
            scoreP2++;
            scorePLayer2.text = scoreP2.ToString();

        }
    }

}
