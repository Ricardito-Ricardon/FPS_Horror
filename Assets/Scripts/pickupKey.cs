using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    [SerializeField] GameObject intractionText, key, spookystuff;
    [SerializeField] AudioSource pickup;
    [SerializeField] bool interactable, scaryEvent;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intractionText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intractionText.SetActive(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                intractionText.SetActive(false);
                interactable = false;
                //pickup.Play();
                if (scaryEvent == true)
                {
                    spookystuff.SetActive(true);
                }
                key.SetActive(false);
            }
        }
    }
}