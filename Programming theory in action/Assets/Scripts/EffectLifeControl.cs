using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLifeControl : MonoBehaviour
{
    private float life = 3f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LifeControl());  
    }

    IEnumerator LifeControl()
    {
        yield return new WaitForSeconds(life);
        Destroy(gameObject);
    }

}
