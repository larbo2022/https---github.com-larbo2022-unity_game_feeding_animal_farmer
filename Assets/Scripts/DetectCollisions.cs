using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
   
    private PlayerState pState;
    [SerializeField] Text feedCounter;
    // [SerializeField] AudioSource collectionSound;

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

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        pState.Feeded();
        
       // collectionSound.Play();
    }
}
