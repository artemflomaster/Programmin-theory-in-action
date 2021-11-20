using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLifeControl : MonoBehaviour
{
    private float lifeTime = 5f;
    public ParticleSystem smallBoom;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LifeControl");
    }

    IEnumerator LifeControl()
    {
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
