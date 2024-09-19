using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float speedUp = 5.0f;
    private float tmpTime = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmpTime += Time.deltaTime;
        transform.Translate(0.03f, 0, 0);
        if (tmpTime >= speedUp)
        {
            transform.Translate(0.04f,0,0);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("GameOver");
        }
    }
}
