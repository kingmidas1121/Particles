using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  SwordOffer: MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;

   [SerializeField] private ParticleSystem Sword1;
   [SerializeField] private ParticleSystem Sword2;

    bool isPlaying = true;

    private void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(isPlaying)
            {
                Sword1.Stop();
                Sword2.Stop();
                isPlaying = false;
            } 
            else
            {
                Sword1.Play();
                Sword2.Play();
                isPlaying = true;
            }
        }
    }
}
