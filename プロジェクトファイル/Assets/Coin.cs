using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // プレイヤーに触れられたら破壊される
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(gameObject);
        }
    }
}
