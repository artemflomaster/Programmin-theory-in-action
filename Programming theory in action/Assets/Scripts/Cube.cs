using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float cubeMass = 0.1f;

    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().mass = cubeMass;
    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameObject.GetComponent<Renderer>().material.color = NewColor();
        }
    }

    private Color32 NewColor()
    {
        byte r = System.Convert.ToByte(Random.Range(0, 256));
        byte g = System.Convert.ToByte(Random.Range(0, 256));
        byte b = System.Convert.ToByte(Random.Range(0, 256));

        return new Color32(r, g, b, 255);
        
    }
}
