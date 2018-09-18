using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Player player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hit()
    {
        if (player.Swing()) { 
            if (Mathf.Abs(player.transform.position.z - transform.position.z) < player.swordRange) {
                Debug.Log("Enemy hit!");
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.Log("too many swings");
        }
       
    }
}
