using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]




public class NavMeshTest : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    [SerializeField] private Transform targetTransform;
    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.destination = targetTransform.position;
    }

    private void Update()
    {
        // On pourrait ajouter une "horloge" qui met a jour a chaque x seconde afin de ne pas avoir
        // a update la position du joueur a chaque frame
        navMeshAgent.destination = targetTransform.position;
    }
}
