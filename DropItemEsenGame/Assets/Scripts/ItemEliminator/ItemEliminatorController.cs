using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEliminatorController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("GoodItem"))
        {
            Destroy(collision.gameObject);
        }
    }
}
