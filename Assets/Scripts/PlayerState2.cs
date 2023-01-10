using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState2 : MonoBehaviour
{
    private static PlayerState2 instance = null;
    public static PlayerState2 Instance => instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);

        // Initialisation du Game Manager...



    }
}