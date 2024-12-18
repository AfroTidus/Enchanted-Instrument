using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawning;
    public float spawnRate;
    public float spawnVariable;
    public GameObject[] projectiles;
    public TextMeshProUGUI display;
    public AudioSource backtrack;


    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 2.0f;
        spawnVariable = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawning)
        {
            StartCoroutine(Spawn());
        }
        
        if(spawnRate <= 2.0f && spawnRate > 1.5f)
        {
            display.text = "Slow";
            backtrack.volume = 0.05f;
        }
        if (spawnRate <= 1.5f && spawnRate > 1.0f)
        {
            display.text = "Normal";
            backtrack.volume = 0.1f;
        }
        if (spawnRate <= 1.0f && spawnRate > 0.5f)
        {
            display.text = "Rockstar";
            backtrack.volume = 0.15f;
        }
        if (spawnRate <= 0.5f && spawnRate > 0.0f)
        {
            display.text = "Crazy Fingers";
            backtrack.volume = 0.2f;
        }

        if (spawnRate < 0.0f)
        {
            spawnRate = 0.1f;
        }
    }

    public void SpawnTimerUpdate(float X)
    {
        spawnVariable = X;
        spawnRate = spawnRate - spawnVariable;
    }

    IEnumerator Spawn() 
    {   
        spawning = true;
        GameObject projectile = projectiles[Random.Range(0, projectiles.Length)];
        Instantiate(projectile, new Vector3(Random.Range(-8.5f, 8.5f), 6f, 0), Quaternion.identity);
        yield return new WaitForSeconds(spawnRate);
        spawning = false;
    }
}
