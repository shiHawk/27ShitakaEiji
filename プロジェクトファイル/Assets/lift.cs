using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.004f, 0);
        if (transform.position.y < -6.7f)
        {
            Destroy(gameObject);
        }
    }
}
