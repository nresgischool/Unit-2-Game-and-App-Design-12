using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public float minValue;
    public float maxValue;
    private float currentTime;
    private float timeTillPrefab = 5;
    private float maxTime = 3;
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        // Sets the timeTillPrefab a random number between 0 and 5
        timeTillPrefab = Random.Range(0, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiates a prefab whenever currentTime goes over the time till next prefab
        currentTime += Time.deltaTime;
        if (currentTime > timeTillPrefab)
        {
            InstantiatePrefab();
        }
    }

    public void InstantiatePrefab()
    {
        // Instiates the prefab and resets currentTime
        Instantiate(prefab, new Vector3(Random.Range(minValue, maxValue), 30, 80), Quaternion.identity);
        currentTime = 0;
    }
}
