using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IEnemyState
{
    private StatePatternEnemy statePatternEnemy;

    public ChaseState(StatePatternEnemy statePatternEnemy)
    {
        this.statePatternEnemy = statePatternEnemy;
    }

    public void OnTriggerEnter(Collider other)
    {
        throw new NotImplementedException();
    }

    public void ToAlertState()
    {
        throw new NotImplementedException();
    }

    public void ToChaseState()
    {
        throw new NotImplementedException();
    }

    public void ToPatrolState()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        throw new NotImplementedException();
    }
}
