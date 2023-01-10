using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyOutOfBounds : MonoBehaviour
{


    private PlayerState pState;

    // private float topBound = 30f;
    private float lowerBound = -10f;

    void Start()
    {
        pState = FindObjectOfType<PlayerState>();
        if (pState != null)
        {
            Debug.Log("c'est bon");
        }
        if (pState == null)
        {
            Debug.Log("c'est pas bon");
        }
    }



    // Update is called once per frame
    void Update()
    {
       /* if( transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else */
        if (transform.position.z < lowerBound)
        {
            pState.TakeDamage();
            Destroy(gameObject);
        }

    }
}
