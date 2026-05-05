using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private int teslaSpawned;
    private int maxSpawned = 20;
    public int teslaToSpawn = 5;
    public GameObject[] SpawnPosition;
    public GameObject Tesla;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPosition = GameObject.FindGameObjectsWithTag("here");
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        teslaSpawned = GameObject.FindGameObjectsWithTag("Bad").Length;
        if (teslaSpawned<maxSpawned)
        {
            
            Spawn();
        }
       
    }

    public void Spawn()
    {
         
       
            int j = Random.Range(0, SpawnPosition.Length);
            GameObject clone = Instantiate(Tesla, SpawnPosition[j].transform.position, SpawnPosition[j].transform.rotation);
        
       
    }
}
