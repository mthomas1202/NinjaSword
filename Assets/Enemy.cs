using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject[] models;
    public Player player;
	// Use this for initialization
	void Start () {
        int randomIndex = Random.Range(0, models.Length);
        for(int i = 0; i < models.Length; i++)
        {
            models[i].SetActive(i == randomIndex);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hit()
    {
        if (player.Swing() && !player.isDead) { 
            if (Mathf.Abs(player.transform.position.z - transform.position.z) < player.swordRange) {
                player.sword.transform.localPosition = Vector3.Lerp(player.sword.transform.localPosition, player.swordTargetPosition, Time.deltaTime * 5f);
                Destroy(gameObject);
            }
        }
       
    }
}
