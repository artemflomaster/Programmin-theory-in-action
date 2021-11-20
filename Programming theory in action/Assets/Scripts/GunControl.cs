using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPipe;
    private Rigidbody bulletRB;
    private float verticalDirection;


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.2F, 0);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject currentBullet = Instantiate(bullet, transform.position, transform.rotation);
            bulletRB = currentBullet.GetComponent<Rigidbody>();
            bulletRB.AddForce(0.12f, 0, 0,ForceMode.Impulse);

        }

        verticalDirection = Input.GetAxis("Vertical");
        gunPipe.transform.Rotate(-verticalDirection, 0, 0);



    }
}
