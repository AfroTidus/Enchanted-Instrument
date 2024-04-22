using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deleter : MonoBehaviour
{
    private ScoreCounter counter;
    private Spawner spawn;
    private int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        counter = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreCounter>();
        spawn = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene("Defeat");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        counter.checkResult(0);
        counter.calculate(-1);
        health--;
        spawn.SpawnTimerUpdate(-0.01f);
    }
}
