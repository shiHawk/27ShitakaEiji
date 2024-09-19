using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Distance : MonoBehaviour
{
    GameObject player;
    GameObject dragon;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
        this.dragon = GameObject.Find("Monster");
        this.distance = GameObject.Find("Text (TMP)");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.player.transform.position.x -
            this.dragon.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text =
            "Distance:" + length.ToString("F2") + "m";
    }
}