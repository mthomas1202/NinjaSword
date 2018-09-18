using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 4.5f;
    public float walkingAmplitude = 0.25f;
    public float walkingFrequency = 2f;
    public float swordRange = 1.75f;
    public float swordCooldown = 0.25f;
    private float coolDownTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        coolDownTimer -= Time.deltaTime;
        if(coolDownTimer <= 0f)
        {

        }
        transform.position += Vector3.forward * speed * Time.deltaTime;

        transform.position = new Vector3
        (
            transform.position.x,
            1.7f + Mathf.Cos(transform.position.z*walkingFrequency) * walkingAmplitude,
            transform.position.z);

	}

    public bool Swing()
    {
        if(coolDownTimer <= 0f)
        {
            coolDownTimer = swordCooldown;
            return true;
        }

        return false;
    }
}
