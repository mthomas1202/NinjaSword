using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 4.5f;
    public float walkingAmplitude = 0.25f;
    public float walkingFrequency = 2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Vector3.forward * speed * Time.deltaTime;

        transform.position = new Vector3
        (
            transform.position.x,
            1.7f + Mathf.Cos(transform.position.z*walkingFrequency) * walkingAmplitude,
            transform.position.z);

	}
}
