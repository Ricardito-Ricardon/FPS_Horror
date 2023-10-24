using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Obunga : MonoBehaviour
{
    [SerializeField] NavMeshAgent ai;
    [SerializeField] Transform player;
    Vector3 dest;

    void Update()
    {
        dest = player.position;
        ai.destination = dest;
    }
}
