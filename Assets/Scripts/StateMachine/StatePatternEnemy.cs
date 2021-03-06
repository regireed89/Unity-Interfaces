﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StatePatternEnemy : MonoBehaviour
{
    public float searchingTurnSpeed = 120f;
    public float searchingDuration = 4f;
    public float sightRange = 20f;
    public Transform[] wayPoints;
    public Transform eyes;
    public Vector3 offset = new Vector3(0,.5f,0);
    public MeshRenderer meshrendererFlag;

    [HideInInspector]
    public Transform chaseTarget;
    [HideInInspector]
    public IEnemyState currentState;
    [HideInInspector]
    public ChaseState chaseStaete;
    [HideInInspector]
    public AlertState alertState;
    [HideInInspector]
    public PatrolState patrolState;
    [HideInInspector]
    public NavMeshAgent navMeshAgent;
    
    public void Awake()
    {
        chaseStaete = new ChaseState(this);
        alertState = new AlertState(this);
        patrolState = new PatrolState(this);

        navMeshAgent = GetComponent<NavMeshAgent>();
    } 


    // Use this for initialization
    void Start ()
    {
        currentState = patrolState;
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentState.UpdateState();
	}

    private void OnTriggerEnter(Collider other)
    {
        currentState.OnTriggerEnter(other);
    }
}
