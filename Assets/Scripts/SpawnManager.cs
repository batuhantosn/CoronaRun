using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject slugPrefab;
    public GameObject downHairPrefab;
    public GameObject upHairPrefab;
    public GameObject slimePrefab;
    public GameObject vaccinePrefab;
    private Vector2 slugSpawnPos = new Vector2(11, 0);
    private Vector2 upHairSpawnPos = new Vector2(11, 3);
    private Vector2 downHairSpawnPos = new Vector2(11, (float)-3.4);
    private Vector2 slimeSpawnPos = new Vector2(14, (float)-4.5);
    private Vector2 vaccineSpawnPos = new Vector2(10, (float)-3.2);
    private Vector2 vaccineSpawnPos2 = new Vector2(10, 0);
    private float startDelayDownPrefabs = 2;
    private float startDelayUpPrefabs = 4;
    private float startDelayVaccinePrefab = 3;
    private float repeatRate = 4;
    private float vaccineRepeatRate = 2;
    private CharacterScript playerControllerScript;
    
    void Start()
    {
        float number = Random.Range(0f, 3f);
        InvokeRepeating("SpawnDown", startDelayDownPrefabs, repeatRate);
        InvokeRepeating("SpawnUp", startDelayUpPrefabs, repeatRate);
        InvokeRepeating("SpawnVaccine", startDelayVaccinePrefab, vaccineRepeatRate);
        playerControllerScript = GameObject.FindWithTag("Player").GetComponent<CharacterScript>();
    }

    // Update is called once per frame
    void Update()
    {
         
    }
  
    void SpawnUp()
    {
        if (playerControllerScript.gameOver == false)
        {
            int xcount = Random.Range(1, 3);
            if(xcount == 1)
            {
                Instantiate(slugPrefab, slugSpawnPos, slugPrefab.transform.rotation);
            }
            else if (xcount == 2)
            {
                Instantiate(upHairPrefab, upHairSpawnPos, upHairPrefab.transform.rotation);
            }
            
        }

    }
    void SpawnDown()
    {
        if (playerControllerScript.gameOver == false)
        {
            int xcount = Random.Range(1, 3);
            if (xcount == 1)
            {
                Instantiate(slimePrefab, slimeSpawnPos, slimePrefab.transform.rotation);
            }
            else if (xcount == 2)
            {
                Instantiate(downHairPrefab, downHairSpawnPos, downHairPrefab.transform.rotation);
            }
            
        }

    }
    void SpawnVaccine()
    {
        if (playerControllerScript.gameOver == false)
        {
            int xcount = Random.Range(1, 3);
            if (xcount == 1)
            {
                Instantiate(vaccinePrefab, vaccineSpawnPos, vaccinePrefab.transform.rotation);
            }
            else if (xcount == 2)
            {
                Instantiate(vaccinePrefab, vaccineSpawnPos2, vaccinePrefab.transform.rotation);
            }
        }
            
    }
}
