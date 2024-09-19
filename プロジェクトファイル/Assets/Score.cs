using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;

    // Start is called before the first frame update
    void Start()
    {
        int a = PlayerPrefs.GetInt("Score");
        Scoretext.text = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
