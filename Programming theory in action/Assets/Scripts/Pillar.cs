using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    private float rotationSpeed_x;
    private float rotationSpeed_y;
    private float rotationSpeed_z;
    private float rotationScalarSpeed;
    private Vector3 rotatingVector;
    private Vector3 rotatingCenter;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed_x = Random.Range(0.1f, 1);
        rotationSpeed_y = Random.Range(0.1f, 1);
        rotationSpeed_z = Random.Range(0.1f, 1);
        rotationScalarSpeed = Random.Range(0.1f, 1);
        rotatingVector = new Vector3(rotationSpeed_x, rotationSpeed_y, rotationSpeed_z);
        rotatingCenter = new Vector3(transform.position.x+0.055f, transform.position.y + 0.288f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotatingCenter, rotatingVector, rotationScalarSpeed);
    }
}
