using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftGenerator : MonoBehaviour
{
    public GameObject liftPrefab;
    float span = 3.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(liftPrefab);
            float px = 130.1754f;
            go.transform.position = new Vector3(px, 4, 0);
        }
    }
}
