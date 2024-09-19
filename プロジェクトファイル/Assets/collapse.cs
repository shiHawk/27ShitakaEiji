using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collapse : MonoBehaviour
{
    bool Down = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Down == true)
        {
            transform.Translate(0, -0.04f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ƒvƒŒƒCƒ„[‚ªG‚ê‚½‚ç—‚¿‚é
        if (collision.gameObject.tag == "Player")
        {
            Down = true;
            if(transform.position.y < -5.7f)
            {
                Destroy(gameObject);
            }
        }
    }
}
