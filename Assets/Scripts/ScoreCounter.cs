using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int Score;
    public int Multiplier;
    public TextMeshProUGUI ScoreDisplay;
    public TextMeshProUGUI MultiplierDisplay;

    // Start is called before the first frame update
    void Start()
    {
        Multiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreDisplay.text = "Score: " + Score;
        if (Multiplier > 8 )
        {
            Multiplier = 8;
        }
        MultiplierDisplay.text = Multiplier + "x";
    }

    public void calculate(int X)
    {
        Score += X * Multiplier;
    }

    public void checkResult(int X)
    {
        if (X == 1)
        {
            Multiplier = Multiplier * 2;
        }

        if (X == 0)
        {
            Multiplier = 1;
        }
    }
}
