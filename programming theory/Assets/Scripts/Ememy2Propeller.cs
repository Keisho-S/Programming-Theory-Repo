using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ememy2Propeller : MonoBehaviour
{ 
    private float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Main Propeller"))
        {
            transform.Rotate(Vector3.up * speed);
        }
        if (CompareTag("Sub Propeller"))
        {
            transform.Rotate(Vector3.right * speed);
        }
    }
}
