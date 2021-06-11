using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineDrivingSound : MonoBehaviour
{
    public float audioPitch;
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }
}
