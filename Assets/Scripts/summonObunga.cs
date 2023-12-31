using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonObunga : MonoBehaviour
{
    [SerializeField] GameObject obunga, block1, block2, block3;
    [SerializeField] Collider collision;
    [SerializeField] bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            obunga.SetActive(true);
            if (blocks == true)
            {
                block1.SetActive(true);
                block2.SetActive(true);
                block3.SetActive(false);
            }
            collision.enabled = false;
        }
    }
}
