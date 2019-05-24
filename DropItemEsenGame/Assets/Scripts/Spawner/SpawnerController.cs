using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject goodCircle;

    private void Start()
    {
        InvokeRepeating("StartSpawn", 3.0f, 1.5f);
    }

    public void StartSpawn()
    {
        float randomValue = Random.Range(-6f, 6f);
        Vector3 newPosition = new Vector3(randomValue, transform.position.y, 0);
        Instantiate(goodCircle, newPosition, Quaternion.identity);
    }

}
