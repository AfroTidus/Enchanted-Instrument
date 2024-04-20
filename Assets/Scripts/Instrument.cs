using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Instrument : MonoBehaviour
{
    string inputOrder = "";
    public bool result;
    public TextMeshProUGUI display;
    private ScoreCounter counter;
    private Spawner spawn;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCounter>();
        spawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
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
            if (GameObject.FindWithTag("Red"))
            {
                Destroy(GameObject.FindWithTag("Red"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
            }
            else
            {
                counter.checkResult(0);
            }
        }

        if (inputOrder == "fff")
        {
            if (GameObject.FindWithTag("Blue"))
            {
                Destroy(GameObject.FindWithTag("Blue"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
            }
            else
            {
                counter.checkResult(0);
            }
        }

        if (inputOrder == "jjj")
        {
            if (GameObject.FindWithTag("Green"))
            {
                Destroy(GameObject.FindWithTag("Green"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
            }
            else
            {
                counter.checkResult(0);
            }
        }

        if (inputOrder == "kkk")
        {
            if (GameObject.FindWithTag("Yellow"))
            {
                Destroy(GameObject.FindWithTag("Yellow"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
            }
            else
            {
                counter.checkResult(0);
            }
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
