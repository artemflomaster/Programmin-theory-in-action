using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLifeControl : MonoBehaviour
{
    private float lifeTime = 5f;
    public ParticleSystem smallBoom;
    private bool toExplode = false;


    void Start()
    {
        StartCoroutine("LifeControl");
    }

    IEnumerator LifeControl()
    {
        yield return new WaitForSeconds(lifeTime);
        toExplode = true;
        
    }
    
    private void OnCollisionStay(Collision collision)
    {
        
        if (toExplode && collision.gameObject.CompareTag("Cube"))
        {
           
           Vector3 point1 = collision.contacts[0].point;
           collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(500f, point1, 3f);
            Explosion();
            Destroy(gameObject);
           
        }else if (toExplode)
        {
            Explosion();
        }
        
    }

    private void Explosion()
    {
        Vector3 instantPos = transform.position;
        Instantiate(smallBoom, instantPos, transform.rotation);
       
        Destroy(gameObject);
    }


}
