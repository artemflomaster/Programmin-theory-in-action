using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCube : Cube //INHERITANCE
{

    public ParticleSystem bigBoom;

    void Start()
    {
        SetParameters();
    }

    public override void SetParameters() //POLYMORPHISM
    {
        base.SetParameters();
        gameObject.GetComponent<Renderer>().material.color = Color.black;

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Vector3 point1 = collision.contacts[0].point;
            collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(200, point1, 1f, 1f, ForceMode.Impulse);
            Explosion();
            Destroy(gameObject);
        }
    }
    private void Explosion()
    {
        Vector3 instantPos = transform.position;
        Instantiate(bigBoom, instantPos, transform.rotation);

        Destroy(gameObject);
    }
}
