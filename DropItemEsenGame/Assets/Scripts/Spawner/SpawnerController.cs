using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject goodItem;
    public GameObject badItem;

    private void Start()
    {
        InvokeRepeating("StartSpawn", 3.0f, 2.5f);
    }

    public void StartSpawn()
    {
        float randomValue = Random.Range(-6f, 6f);
        Vector3 newPosition = new Vector3(randomValue, transform.position.y, 0);
        GameObject temp = Instantiate(goodItem, newPosition, Quaternion.identity);

        int itemRandomValue = Random.Range(3, 5);
        temp.GetComponent<ItemMovement>().ModifySpeed(itemRandomValue);
    }

}
