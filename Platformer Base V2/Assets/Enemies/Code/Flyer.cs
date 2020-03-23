using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : Enemy
{
    float xSpeed;
    float ySpeed;
    float maxSpeed;
    float sightDistance;

    public enum WalkerState
    {
        Idle,
        Chase
    }

    public WalkerState CurrentState;

    void Start()
    {
        xSpeed = 0f;
        ySpeed = 0f;
        maxSpeed = 1.5f;
        sightDistance = 180;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
