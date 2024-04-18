using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Instrument : MonoBehaviour
{
    string inputOrder = "";
    public TextMeshProUGUI display;
    private ScoreCounter counter;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            inputOrder = inputOrder + "d";
            display.text = "Notes: " + inputOrder;
        }
        if (Input.GetKeyDown("f"))
        {
            inputOrder = inputOrder + "f";
            display.text = "Notes: " + inputOrder;
        }
        if (Input.GetKeyDown("j"))
        {
            inputOrder = inputOrder + "j";
            display.text = "Notes: " + inputOrder;
        }
        if (Input.GetKeyDown("k"))
        {
            inputOrder = inputOrder + "k";
            display.text = "Notes: " + inputOrder;
        }

        if (inputOrder == "ddd")
        {
            Destroy(GameObject.FindWithTag("Red"));
            counter.calculate(1);
        }

        if (inputOrder == "fff")
        {
            Destroy(GameObject.FindWithTag("Blue"));
            counter.calculate(1);
        }

        if (inputOrder == "jjj")
        {
            Destroy(GameObject.FindWithTag("Green"));
            counter.calculate(1);
        }

        if (inputOrder == "kkk")
        {
            Destroy(GameObject.FindWithTag("Yellow"));
            counter.calculate(1);
        }

        if (inputOrder.Length >= 3)
        {
            inputOrder = "";
            StartCoroutine(clear());
        }
    }

    IEnumerator clear ()
    {
        yield return new WaitForSeconds(0.1f);
        display.text = "Notes: " + inputOrder;
    }
}
