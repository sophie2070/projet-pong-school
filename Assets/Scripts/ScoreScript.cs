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
