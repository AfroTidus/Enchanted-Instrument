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
    public Sprite[] KeyStates;
    public AudioSource[] KeySounds;
    public GameObject Visualisation;
    private ScoreCounter counter;
    private Spawner spawn;
    private SpriteRenderer changer;

    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCounter>();
        spawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
        changer = Visualisation.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            inputOrder = inputOrder + "d";
            display.text = "Notes: " + inputOrder;
            StartCoroutine(clear2(1));
        }
        if (Input.GetKeyDown("f"))
        {
            inputOrder = inputOrder + "f";
            display.text = "Notes: " + inputOrder;
            StartCoroutine(clear2(2));
        }
        if (Input.GetKeyDown("j"))
        {
            inputOrder = inputOrder + "j";
            display.text = "Notes: " + inputOrder;
            StartCoroutine(clear2(3));
        }
        if (Input.GetKeyDown("k"))
        {
            inputOrder = inputOrder + "k";
            display.text = "Notes: " + inputOrder;
            StartCoroutine(clear2(4));
        }

        if (inputOrder == "ddd")
        {
            if (GameObject.FindWithTag("Red"))
            {
                Destroy(GameObject.FindWithTag("Red"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
                KeySounds[0].Play();
            }
            else
            {
                counter.checkResult(0);
                KeySounds[4].Play();
            }
        }

        if (inputOrder == "fjk")
        {
            if (GameObject.FindWithTag("Blue"))
            {
                Destroy(GameObject.FindWithTag("Blue"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
                KeySounds[1].Play();
            }
            else
            {
                counter.checkResult(0);
                KeySounds[4].Play();
            }
        }

        if (inputOrder == "dfj")
        {
            if (GameObject.FindWithTag("Green"))
            {
                Destroy(GameObject.FindWithTag("Green"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
                KeySounds[2].Play();
            }
            else
            {
                counter.checkResult(0);
                KeySounds[4].Play();
            }
        }

        if (inputOrder == "jkj")
        {
            if (GameObject.FindWithTag("Yellow"))
            {
                Destroy(GameObject.FindWithTag("Yellow"));
                counter.calculate(1);
                spawn.SpawnTimerUpdate(0.03f);
                counter.checkResult(1);
                KeySounds[3].Play();
            }
            else
            {
                counter.checkResult(0);
                KeySounds[4].Play();
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

    IEnumerator clear2(int X)
    {
        changer.sprite = KeyStates[X];
        yield return new WaitForSeconds(0.1f);
        changer.sprite = KeyStates[0];
    }
}
