using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval;
    public float maxYOffset;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        var yOffset = Random.Range(-maxYOffset, maxYOffset);
        Instantiate(objectToSpawn, transform.position + new Vector3(0, yOffset, 0), Quaternion.identity);
    }
}
