using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI display;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        display.text = "Score: " + Score;
    }

    public void calculate(int X)
    {
        Score += X;
    }
}
