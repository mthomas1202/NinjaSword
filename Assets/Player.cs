﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject sword;
    public float speed = 4.5f;
    public float walkingAmplitude = 0.25f;
    public float walkingFrequency = 2f;
    public float swordRange = 1.75f;
    public float swordCooldown = 0.25f;
    public bool isDead = false;
    public bool hasWon = false;

    private float coolDownTimer;
    public Vector3 swordTargetPosition;
	// Use this for initialization
	void Start () {
        swordTargetPosition = sword.transform.localPosition;
        Debug.Log(swordTargetPosition);
	}
	
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;
        if(isDead)
        {
            return;
        }

        transform.position += Vector3.forward * speed * Time.deltaTime;

        transform.position = new Vector3
        (
            transform.position.x,
            1.7f + Mathf.Cos(transform.position.z*walkingFrequency) * walkingAmplitude,
            transform.position.z
        );

	}

    void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<Enemy>() != null)
        {
            isDead = true;
        }

        else if(collider.tag == "FinishLine")
        {
            hasWon = true;
        }
    }

    public bool Swing()
    {
        bool canSwing = false;
        if(coolDownTimer <= 0f)
        {
            coolDownTimer = swordCooldown;
            swordTargetPosition = new Vector3(-swordTargetPosition.x, swordTargetPosition.y, swordTargetPosition.z);
            canSwing = true;
        }

        return canSwing;
    }
}
