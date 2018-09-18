using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

    public Player player;
    public TextMesh infoText;
    private float restartTimer = 3f;
	// Use this for initialization
	void Start () {
        infoText.text = "Race to the finish!";
	}
	
	// Update is called once per frame
	void Update () {
        if (player.isDead)
        {
            infoText.text = "You Lost. :(";
            restartTimer -= Time.deltaTime;
            if(restartTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (player.hasWon)
        {
            infoText.text = "You Won! :)";
            restartTimer -= Time.deltaTime;
            if (restartTimer <= 0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
	}
}
