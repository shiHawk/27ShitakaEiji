using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.006f, 0, 0);
        if(transform.position.x > 20f)
        {
            transform.position = new Vector3(-13, -1.64f, 0);
        }
    }
}
