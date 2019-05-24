using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(transform.position.x > -7)
            { 
                transform.Translate(new Vector3(-1f, 0, 0)* 6 * Time.deltaTime);
            }
        }
        else if(Input.GetKey(KeyCode.D))
        {
            if(transform.position.x < 7)
            { 
                transform.Translate(new Vector3(1f, 0, 0) * 6 * Time.deltaTime);
            }
        }
    }
}
