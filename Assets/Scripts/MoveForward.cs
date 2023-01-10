using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speedf = 40f;
    

  
    void Update()
    {
        transform.Translate(Vector3.forward * speedf * Time.deltaTime);
    }
}
