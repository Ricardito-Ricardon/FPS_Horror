using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField] GameObject lightSource;
    [SerializeField] bool toggle;
    [SerializeField] AudioSource toggleSound;

    void Start()
    {
        if (toggle == false)
        {
            lightSource.SetActive(false);
        }
        if (toggle == true)
        {
            lightSource.SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if (toggle == false)
            {
                lightSource.SetActive(false);
            }
            if (toggle == true)
            {
                lightSource.SetActive(true);
            }
        }
    }
}
