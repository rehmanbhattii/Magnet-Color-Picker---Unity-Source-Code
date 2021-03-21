using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorCounterScript : MonoBehaviour
{
    public float TotalGreens;
    public Text GreenTextCounter;
    float GreenObjects = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Green"))
        {
            GreenObjects++;

            GreenTextCounter.text = Mathf.RoundToInt((GreenObjects/TotalGreens)*100).ToString();
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag.Equals("Green"))
        {
            GreenObjects--;
            GreenTextCounter.text = Mathf.RoundToInt((GreenObjects / TotalGreens) * 100).ToString();
        }
    }
}
