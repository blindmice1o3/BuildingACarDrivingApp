using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playHorn : MonoBehaviour
{

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();    
    }

    public void beep() {
        audio.Play();
    }
    
}
