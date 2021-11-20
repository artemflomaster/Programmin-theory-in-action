using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPipe;
    public ParticleSystem gunBoom;
    private Rigidbody bulletRB;


    private float verticalDirection;
   


   
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.2F, 0);
    }

   
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject currentBullet = Instantiate(bullet, transform.position, transform.rotation);
            bulletRB = currentBullet.GetComponent<Rigidbody>();
            gunBoom.Play();
            bulletRB.AddForce(0.18f, 0, 0, ForceMode.Impulse);


        }

        verticalDirection = Input.GetAxis("Vertical");
        gunPipe.transform.Rotate(-verticalDirection, 0, 0);



    }
}
