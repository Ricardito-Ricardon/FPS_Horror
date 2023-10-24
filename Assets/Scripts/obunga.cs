using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class obunga : MonoBehaviour
{
    [SerializeField] NavMeshAgent ai;
    Vector3 dest;

    void Update()
    {
        dest = GameplayStatics.GetPlayerGameObject().transform.position;
        ai.destination = dest;
    }
}
