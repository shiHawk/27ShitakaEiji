using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OP2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.006f, 0, 0);
        if (transform.position.x > 18f)
        {
            transform.position = new Vector3(-15, -0.2303084f, 0);
        }
    }
}
