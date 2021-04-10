using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    private void Update()
    {
        PlayerMovement();
    }
    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back* 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }
    }
}
