using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    [Header("Time")]
    public float time;
 

    
    void Update()
    {
        time = time - 1 * Time.deltaTime;

        if (time <= 0)
        {
            Destroy(gameObject);
        }

    }
}
