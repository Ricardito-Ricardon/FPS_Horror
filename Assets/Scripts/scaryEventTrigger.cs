using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaryEventTrigger : MonoBehaviour
{
    [SerializeField] GameObject scare;
    [SerializeField] AudioSource scareSound;
    [SerializeField] Collider collision;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameplayStatics.GetPlayerGameObject())
        {
            scare.SetActive(true);
            //scareSound.Play();
            collision.enabled = false;
        }
    }
}