﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    // Player Variables
    public string myName = "No Name";

    // Tank Variables
    public float movementSpeed;
    public float backwardMovementSpeed;
    public float rotationSpeed;
    public float healthCurrent;
    public float healthMax;

    public float noiseLevelReducPerSec;
    public float rotateNoiseLevel;
    public float moveNoiseLevel;

    // Bullet Variables
    public float bulletCooldownMax;
    public float bulletCooldownCurrent;
    public float bulletNoiseLevel;


    // Missile Variables
    public float missileCooldownMax;
    public float missileCooldownCurrent;
    public float missileNoiseLevel;

    // Sense Variables
    public float viewDistance;
    public float fieldOfView;
    public float hearingDistance;
    public float wallDetectDistance;
    public float noiseLevel;
}
