using UnityEngine;



public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject[] Hazards;
    private float TimeBtwSpawns;
    public float startTimeBtwSpawns;
    public float minTimeBetweenSpawns;
    public float decrease;


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    
    void Update()
    {
        
        
            if (TimeBtwSpawns <= 0)// this causes the if statement to take place once the time has elapsed
            {
                Transform randomSpawnPoint = SpawnPoints[Random.Range(0, SpawnPoints.Length)];// makes a random choice between the spawn points selected
                GameObject RandomHazards = Hazards[Random.Range(0, Hazards.Length)];// this gives the pottenchtial of a random hazards if more were t be added
                Instantiate(RandomHazards, randomSpawnPoint.position, Quaternion.identity);

                if (startTimeBtwSpawns > minTimeBetweenSpawns)
                {
                    startTimeBtwSpawns -= decrease;
                }// this should cause the spawn rate to increase overtime till it reaches a min amount of ime between spawns

                TimeBtwSpawns = startTimeBtwSpawns;
                //Spawn Asteroid
            }
            else
            {
                TimeBtwSpawns -= Time.deltaTime;
            }// this is th timer between the spawns
        
        
    }
}
