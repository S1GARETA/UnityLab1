using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey (KeyCode.L))
        {
            Destroy(gameObject);
        }
    }
}
