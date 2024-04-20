using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deleter : MonoBehaviour
{
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
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        counter.checkResult(0);
        counter.calculate(-1);
        spawn.SpawnTimerUpdate(-0.01f);
    }
}
