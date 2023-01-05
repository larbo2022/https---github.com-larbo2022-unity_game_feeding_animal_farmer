using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
  //  int feed = 0;

   // [SerializeField] Text feedCounter;
   // [SerializeField] AudioSource collectionSound;
    // Start is called before the first frame update
    

    // Update is called once per frame
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
      //  feed++;
       // feedCounter.text = "" + feed;
       // collectionSound.Play();
    }
}
