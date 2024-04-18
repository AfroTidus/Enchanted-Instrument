using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Instrument : MonoBehaviour
{
    string inputOrder = "";
    public TextMeshProUGUI display;

    // Start is called before the first frame update
    void Start()
    {

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
        }

        if (inputOrder == "fff")
        {
            Destroy(GameObject.FindWithTag("Blue"));
        }

        if (inputOrder == "jjj")
        {
            Destroy(GameObject.FindWithTag("Green"));
        }

        if (inputOrder == "kkk")
        {
            Destroy(GameObject.FindWithTag("Yellow"));
        }

        if (inputOrder.Length == 3)
        {
            inputOrder = "";
            StartCoroutine(clear());
        }
    }

    IEnumerator clear ()
    {
        yield return new WaitForSeconds(0.5f);
        display.text = "Notes: " + inputOrder;
    }
}
