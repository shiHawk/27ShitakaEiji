using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // モンスターに触れられたら破壊される
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject);
        }
    }
}
