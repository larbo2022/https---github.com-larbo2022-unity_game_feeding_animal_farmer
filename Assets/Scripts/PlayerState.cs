using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour
{
    [SerializeField] Text feedCounter;
    [SerializeField] AudioSource collectionSound;

    [SerializeField] Image healthBarFill;

    [SerializeField]
    private float maxLife = 100f;
    public float currentLife;
    public int feed;


    // Start is called before the first frame update
    void Awake()
    {
        currentLife = maxLife;
        feed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBarFill();
        UpdateFeedCounter();
     }

    public void TakeDamage()
    {

        currentLife -= 10;
        UpdateHealthBarFill();

    }
    public void Feeded()
    {    
        feed++;
        UpdateFeedCounter();
        
    }
    public void UpdateHealthBarFill()
    {
        healthBarFill.fillAmount = currentLife / maxLife;
    }

    public void UpdateFeedCounter()
    {
      
        feedCounter.text = "" + feed;
    }
}
