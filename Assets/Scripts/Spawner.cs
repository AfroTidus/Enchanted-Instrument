using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    bool spawning;
    public GameObject[] projectiles;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawning)
        {
            StartCoroutine(Spawn());
        }
    }


    IEnumerator Spawn() 
    {   
        spawning = true;
        GameObject projectile = projectiles[Random.Range(0, projectiles.Length)];
        Instantiate(projectile, new Vector3(Random.Range(-8.5f, 8.5f), 6f, 0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        spawning = false;
    }
}
